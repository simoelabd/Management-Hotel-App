using HotelManagment.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace HotelManagment.View
{
    public partial class frmBookingView : SampleView
    {
        public frmBookingView()
        {
            InitializeComponent();
        }

        private void frmBookingView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmBookingAdd());
            LoadData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            System.Windows.Forms.ListBox lb = new System.Windows.Forms.ListBox();
            //lb.Items.Add(dgvSr);
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvcusID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvRoomID);
            lb.Items.Add(dgvRoom);
            lb.Items.Add(dgvIn);
            lb.Items.Add(dgvOut);
            lb.Items.Add(dgvDay);
            lb.Items.Add(dgvPrix);
            lb.Items.Add(dgvAmount);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvRece);

            string qry = @"Select b.bookID, b.customerID, c.cName, b.roomID, r.rName, b.checkinDate, 
                            b.checkoutDate, b.days, b.prix, b.amount, b.status, b.received
                            from bookings b inner join customers c on c.cusID = b.customerID
                            inner join room r on r.roomID = b.roomID
                            where cName like '%" + txtSearch.Text + "%'";

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Code
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedite" && e.RowIndex != -1)
            {
                frmBookingAdd frm = new frmBookingAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.custID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcusID"].Value);
                frm.roomID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvRoomID"].Value);
                frm.txtcheckIN.Text = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells["dgvIn"].Value).ToString("dd/MM/yyyy");
                frm.txtcheckout.Text = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells["dgvOut"].Value).ToString("dd/MM/yyyy");
                frm.txtDays.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvDay"].Value);
                frm.txtPrix.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrix"].Value);
                frm.txtAmount.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvAmount"].Value);
                frm.txtRece.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvRece"].Value);
                frm.cbStatus.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }

            //Delete Code
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel" && e.RowIndex != -1)
            {
                DataGridViewRow row = guna2DataGridView1.CurrentRow;
                int ID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (ID != 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    if (guna2MessageDialog1.Show("Are you sure you want to delete") == DialogResult.Yes)
                    {
                        try
                        {
                            string qry = @"Delete from bookings where bookID =" + ID + " ";
                            Hashtable ht = new Hashtable();

                            int r = MainClass.SQL(qry, ht);

                            if (r > 0)
                            {
                                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                                guna2MessageDialog1.Show("Deleted Successfully");
                                ID = 0;
                                LoadData();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }

            

            //print code de bone de reservation 
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvPrint" && e.RowIndex != -1)
            {
                DataGridViewRow row = guna2DataGridView1.CurrentRow;

                string customerName = row.Cells["dgvCustomer"].Value.ToString();
                string roomName = row.Cells["dgvRoom"].Value.ToString();
                string checkIn = Convert.ToDateTime(row.Cells["dgvIn"].Value).ToString("dd/MM/yyyy");
                string checkOut = Convert.ToDateTime(row.Cells["dgvOut"].Value).ToString("dd/MM/yyyy");
                string days = row.Cells["dgvDay"].Value.ToString();
                string amount = row.Cells["dgvAmount"].Value.ToString();

                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += (s, ev) =>
                {
                    // Définir les polices
                    var titleFont = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                    var headerFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                    var bodyFont = new System.Drawing.Font("Arial", 12);

                    // Couleur de texte
                    Brush textBrush = Brushes.Black;

                    // Marges et positions
                    int margin = 40;
                    int yPos = margin;

                    // Ajouter le logo avec une taille plus grande
                    System.Drawing.Image logo = System.Drawing.Image.FromFile("LogoHotel1.png");
                    ev.Graphics.DrawImage(logo, new System.Drawing.Rectangle(margin, yPos, 150, 100)); // Logo plus grand
                    yPos += 120;

                    // Titre du document
                    ev.Graphics.DrawString("BON DE RÉSERVATION", titleFont, textBrush, margin + 150, yPos);
                    yPos += 40;

                    // Informations client
                    ev.Graphics.DrawString($"Nom du client : {customerName}", headerFont, textBrush, margin, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString($"Chambre : {roomName}", bodyFont, textBrush, margin, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString($"Date d'arrivée : {checkIn}", bodyFont, textBrush, margin, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString($"Date de départ : {checkOut}", bodyFont, textBrush, margin, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString($"Nombre de jours : {days}", bodyFont, textBrush, margin, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString($"Montant total : {amount} MAD", headerFont, textBrush, margin, yPos);
                    yPos += 40;

                    // Ajouter une ligne de séparation
                    ev.Graphics.DrawLine(Pens.Black, margin, yPos, ev.PageBounds.Width - margin, yPos);
                    yPos += 20;

                    // Message de remerciement
                    ev.Graphics.DrawString("Merci d'avoir choisi notre hôtel. Nous vous souhaitons un excellent séjour!", bodyFont, textBrush, margin, yPos);
                };

                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDoc
                };

                previewDialog.ShowDialog();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Définit le contexte de licence pour EPPlus
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Crée un nouveau fichier Excel
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    // Crée une feuille de calcul
                    var worksheet = package.Workbook.Worksheets.Add("Réservations");

                    // Définir les en-têtes
                    worksheet.Cells[1, 1].Value = "ID Réservation";
                    worksheet.Cells[1, 2].Value = "Nom du Client";
                    worksheet.Cells[1, 3].Value = "Chambre";
                    worksheet.Cells[1, 4].Value = "Date d'Arrivée";
                    worksheet.Cells[1, 5].Value = "Date de Départ";
                    worksheet.Cells[1, 6].Value = "Nombre de Jours";
                    worksheet.Cells[1, 7].Value = "Montant Total";
                    worksheet.Cells[1, 8].Value = "Montant Reçu";

                    // Remplir les données depuis le DataGridView
                    for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                    {
                        // Vérifie si la ligne n'est pas vide (ignorer les nouvelles lignes)
                        if (!guna2DataGridView1.Rows[i].IsNewRow)
                        {
                            worksheet.Cells[i + 2, 1].Value = guna2DataGridView1.Rows[i].Cells["dgvID"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 2].Value = guna2DataGridView1.Rows[i].Cells["dgvCustomer"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 3].Value = guna2DataGridView1.Rows[i].Cells["dgvRoom"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 4].Value = guna2DataGridView1.Rows[i].Cells["dgvIn"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 5].Value = guna2DataGridView1.Rows[i].Cells["dgvOut"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 6].Value = guna2DataGridView1.Rows[i].Cells["dgvDay"].Value?.ToString() ?? "";
                            worksheet.Cells[i + 2, 7].Value = $"{guna2DataGridView1.Rows[i].Cells["dgvAmount"].Value?.ToString() ?? ""} DH";
                            worksheet.Cells[i + 2, 8].Value = guna2DataGridView1.Rows[i].Cells["dgvRece"].Value?.ToString() ?? "";
                        }
                    }

                    // Ouvre la boîte de dialogue pour sauvegarder le fichier
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Fichiers Excel (*.xlsx)|*.xlsx",
                        Title = "Exporter vers Excel"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Enregistre le fichier Excel
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);

                        // Message de confirmation
                        MessageBox.Show("Exportation réussie !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation : " + ex.Message);
            }
        }





    }
}
