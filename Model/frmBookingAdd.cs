using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace HotelManagment.Model
{
    public partial class frmBookingAdd : SampleAdd
    {
        public frmBookingAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int custID = 0;
        public int roomID = 0;

        private void frmBookingAdd_Load(object sender, EventArgs e)
        {
            string qry1 = @"Select cusID 'id', cName 'name' from customers";
            MainClass.CBFill(qry1, cbCustomer);

            string qry2 = @"Select roomID 'id', rName 'name' from room";
            MainClass.CBFill(qry2, cbRoom);

            txtPrix.Text = "";

            if (id > 0)
            {
                cbRoom.SelectedValue = roomID;
                cbCustomer.SelectedValue = custID;
            }

        }

        private void calDays()
        {
            if (txtcheckIN.Text != "" && txtcheckout.Text != "")
            {
                DateTime d1 = Convert.ToDateTime(txtcheckIN.Text);
                DateTime d2 = Convert.ToDateTime(txtcheckout.Text);

                int days = (d2 - d1).Days + 1;
                txtDays.Text = days.ToString();

                double prix = Convert.ToDouble(txtPrix.Text);

                double amt = days * prix;

                txtAmount.Text = amt.ToString();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {

            string qry = "";

            if (string.IsNullOrEmpty(cbCustomer.SelectedValue.ToString()) ||
                string.IsNullOrEmpty(cbRoom.SelectedValue.ToString()) ||
                string.IsNullOrEmpty(txtcheckIN.Text) ||
                string.IsNullOrEmpty(txtcheckout.Text) ||
                string.IsNullOrEmpty(txtDays.Text) ||
                string.IsNullOrEmpty(txtPrix.Text) ||
                string.IsNullOrEmpty(txtAmount.Text) ||
                string.IsNullOrEmpty(txtRece.Text) ||
                string.IsNullOrEmpty(txtChange.Text) ||
                string.IsNullOrEmpty(cbStatus.Text))
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Caption = "Erreur";
                guna2MessageDialog1.Text = "Tous les champs doivent être remplis.";
                guna2MessageDialog1.Show();
                return; // Arrêter l'exécution si un champ est manquant
            }

            if (id == 0) // Save
            {
                qry = @"INSERT INTO bookings (customerID, roomID, checkinDate, checkoutDate, status, days, prix, 
                    amount, received, `change`) 
                VALUES (@customerID, @roomID, @checkinDate, @checkoutDate, @status, @days, 
                    @prix, @amount, @received, @change)";
            }
            else // Update
            {
                qry = @"UPDATE bookings 
                SET customerID = @customerID, roomID = @roomID, checkinDate = @checkinDate, 
                    checkoutDate = @checkoutDate, status = @status, days = @days, prix = @prix, 
                    amount = @amount, received = @received, `change` = @change 
                WHERE bookID = @id";
            }

            try
            {
                // Vérifier les valeurs avant insertion
                int customerID = Convert.ToInt32(cbCustomer.SelectedValue);
                int roomID = Convert.ToInt32(cbRoom.SelectedValue);
                DateTime checkinDate = Convert.ToDateTime(txtcheckIN.Text);
                DateTime checkoutDate = Convert.ToDateTime(txtcheckout.Text);
                double days = Convert.ToDouble(txtDays.Text);
                double prix = Convert.ToDouble(txtPrix.Text);
                double amount = Convert.ToDouble(txtAmount.Text);
                double received = Convert.ToDouble(txtRece.Text);
                double change = Convert.ToDouble(txtChange.Text);
                string status = cbStatus.Text;

                // Créer les paramètres pour la requête principale
                Hashtable ht = new Hashtable
                {
                    { "@id", id },
                    { "@customerID", customerID },
                    { "@roomID", roomID },
                    { "@checkinDate", checkinDate },
                    { "@checkoutDate", checkoutDate },
                    { "@status", status },
                    { "@days", days },
                    { "@prix", prix },
                    { "@amount", amount },
                    { "@received", received },
                    { "@change", change }
                };

                // Exécuter la requête principale
                int r = MainClass.SQL(qry, ht);

                // Mettre à jour le statut de la chambre
                string roomStatus = (status == "Checked In") ? "Occupied" : "Available";
                string qry2 = "UPDATE room SET rStatus = @rStatus WHERE roomID = @roomID";

                Hashtable ht2 = new Hashtable
                {
                    { "@rStatus", roomStatus },
                    { "@roomID", roomID }
                };

                MainClass.SQL(qry2, ht2);

                
                if (r > 0)
                {
                    // Envoi d'email après insertion/mise à jour
                    string emailClient = RecupererEmailClient(customerID);

                    if (!string.IsNullOrEmpty(emailClient))
                    {
                        string sujet = "Confirmation de réservation";
                        string corpsMessage = $"Bonjour,\n\nVotre réservation pour la chambre '{cbRoom.Text}' " +
                            $"du {checkinDate:dd/MM/yyyy} au {checkoutDate:dd/MM/yyyy} a été confirmée.\n\n" +
                            $"Montant total : {amount} MAD.\n\nMerci de nous avoir choisir !";

                        EnvoyerEmailReservation(emailClient, sujet, corpsMessage);
                    }
                    MainClass.ClearAll(this);
                    guna2MessageDialog1.Show("Saved successfully");
                    id = 0;
                }
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show("Une erreur est survenue : " + ex.Message);
            }
        }

        private string RecupererEmailClient(int customerID)
        {
            string email = string.Empty;

            try
            {
                string query = "SELECT cEmail FROM customers WHERE cusID = @customerID";

                using (MySqlCommand cmd = new MySqlCommand(query, MainClass.con))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    if (MainClass.con.State != ConnectionState.Open)
                    {
                        MainClass.con.Open();
                    }

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        email = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération de l'email : " + ex.Message);
            }
            finally
            {
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }
            }

            return email;
        }

        private void EnvoyerEmailReservation(string destinataire, string sujet, string corpsMessage)
        {
            try
            {
                // Configuration du client SMTP
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                // Activer SSL pour sécuriser la connexion
                client.EnableSsl = true;
                // Authentification
                client.Credentials = new NetworkCredential("ouledelabd.mohamed@gmail.com", "vuhxyzxihvchqgsa");

                // Création et configuration du message email
                MailMessage mail = new MailMessage("ouledelabd.mohamed@gmail.com", destinataire, sujet, corpsMessage);

                // Envoi du message
                client.Send(mail);
                MessageBox.Show("Email envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'email : " + ex.Message);
            }
        }


        private void txtRece_TextChanged(object sender, EventArgs e) {
            // Vérifier que les champs ne sont pas vides
            if (!string.IsNullOrWhiteSpace(txtAmount.Text) && !string.IsNullOrWhiteSpace(txtRece.Text))
            {
                if (double.TryParse(txtAmount.Text, out double amt) && double.TryParse(txtRece.Text, out double rece))
                {
                    // Calculer et mettre à jour le texte
                    txtChange.Text = (amt - rece).ToString();
                }
                else
                {
                    // Alerter si la conversion échoue
                    txtChange.Text = "Invalid input";
                }
            }
            else
            {
                // Réinitialiser le champ si les valeurs sont invalides
                txtChange.Text = string.Empty;
            }
        }


        private void txtcheckIN_Leave(object sender, EventArgs e)
        {
            calDays();
        }

        private void txtcheckout_Leave(object sender, EventArgs e)
        {
            calDays();
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRoom.SelectedIndex != -1)
            {
                string qry = @"Select rPrix from Room where roomID = "+cbRoom.SelectedValue+"";
                MySqlCommand cmd = new MySqlCommand(qry,MainClass.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    txtPrix.Text = dt.Rows[0]["rPrix"].ToString();
                }
            }
        }


    }
}
