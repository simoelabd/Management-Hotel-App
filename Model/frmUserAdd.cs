using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment.Model
{
    public partial class frmUserAdd : SampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            // Validation des entrées
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                guna2MessageDialog1.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Vérification d'unicité
            if (IsDuplicate("uName", txtName.Text))
            {
                guna2MessageDialog1.Show("The name is already used !");
                return;
            }

            if (IsDuplicate("uUsername", txtUsername.Text))
            {
                guna2MessageDialog1.Show("Email is already in used !");
                return;
            }

            if (IsDuplicate("uPhone", txtPhone.Text))
            {
                guna2MessageDialog1.Show("The phone is already in use !");
                return;
            }

            // Construction de la requête
            string qry = id == 0
                ? @"INSERT INTO users (uName, uUsername, uPass, uPhone) 
            VALUES (@uName, @uUsername, @uPass, @Phone)"
                : @"UPDATE users SET uName=@uName, uUsername=@uUsername, uPass=@uPass, uPhone=@Phone
            WHERE userID = @id";

            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@uName", txtName.Text },
                { "@uUsername", txtUsername.Text },
                { "@uPass", txtPass.Text },
                { "@Phone", txtPhone.Text }
            };

            // Exécution de la requête
            int r = MainClass.SQL(qry, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtName.Focus();
                guna2MessageDialog1.Show("User Saved successfully");
                id = 0;
            }
            else
            {
                guna2MessageDialog1.Show("Operation failed. Please try again.");
            }
        }

        // Méthode pour vérifier si une valeur existe déjà dans la base
        private bool IsDuplicate(string columnName, string value)
        {
            // Vérifier les colonnes autorisées
            string[] allowedColumns = { "uName", "uUsername", "uPhone" };
            if (!allowedColumns.Contains(columnName))
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Text = "Colonne invalide !";
                guna2MessageDialog1.Show();
                return false; // Retourne false si la colonne est invalide
            }

            // Requête SQL pour vérifier les doublons
            string checkQry = $@"
                SELECT COUNT(*) FROM users 
                WHERE {columnName} = @value AND userID <> @id";

            // Création du Hashtable pour les paramètres
            Hashtable ht = new Hashtable
            {
                { "@value", value },
                { "@id", id }
            };

            // Exécuter la requête et obtenir le résultat
            int duplicateCount = Convert.ToInt32(MainClass.SQL(checkQry, ht));

            // Retourner true si un doublon est trouvé
            return duplicateCount > 0;
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
