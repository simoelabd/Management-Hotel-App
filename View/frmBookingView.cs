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

            //print code
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
                    var titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                    var headerFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                    var bodyFont = new System.Drawing.Font("Arial", 12);

                    // Couleur de texte
                    Brush textBrush = Brushes.Black;

                    // Marges et positions
                    int margin = 20;
                    int yPos = margin;

                    // Titre du document
                    ev.Graphics.DrawString("Bon de Réservation", titleFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 40;  // Espacement après le titre

                    // Ajouter une ligne de séparation
                    ev.Graphics.DrawLine(Pens.Black, margin, yPos, ev.PageBounds.Width - margin, yPos);
                    yPos += 20;  // Espacement après la ligne

                    // Informations client
                    ev.Graphics.DrawString($"Nom du client : {customerName}", headerFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 30;  // Espacement

                    ev.Graphics.DrawString($"Chambre : {roomName}", bodyFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 30;

                    ev.Graphics.DrawString($"Date d'arrivée : {checkIn}", bodyFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 30;

                    ev.Graphics.DrawString($"Date de départ : {checkOut}", bodyFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 30;

                    ev.Graphics.DrawString($"Nombre de jours : {days}", bodyFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 30;

                    ev.Graphics.DrawString($"Montant total : {amount} MAD", headerFont, textBrush, new System.Drawing.Point(margin, yPos));
                    yPos += 40;  // Espacement avant la fin

                    // Ajouter une ligne de séparation en bas
                    ev.Graphics.DrawLine(Pens.Black, margin, yPos, ev.PageBounds.Width - margin, yPos);
                };
                printDoc.Print();

                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDoc
                };

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Créer une instance d'Excel
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            // Créer un nouveau classeur
            var workBook = excelApp.Workbooks.Add();
            var workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];

            // Ajouter un titre
            workSheet.Cells[1, 1] = "Bon de Réservation";
            workSheet.Cells[2, 1] = "-------------------------------------------------";

            // Ajouter les en-têtes de colonnes
            workSheet.Cells[3, 1] = "ID Réservation";
            workSheet.Cells[3, 2] = "ID Client";
            workSheet.Cells[3, 3] = "Nom du Client";
            workSheet.Cells[3, 4] = "Chambre";
            workSheet.Cells[3, 5] = "Date d'Arrivée";
            workSheet.Cells[3, 6] = "Date de Départ";
            workSheet.Cells[3, 7] = "Nombre de Jours";
            workSheet.Cells[3, 8] = "Montant Total";
            workSheet.Cells[3, 9] = "Statut";
            workSheet.Cells[3, 10] = "Montant Reçu";

            // Remplir les données du DataGridView dans Excel
            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                workSheet.Cells[i + 4, 1] = guna2DataGridView1.Rows[i].Cells["dgvID"].Value.ToString();
                workSheet.Cells[i + 4, 2] = guna2DataGridView1.Rows[i].Cells["dgvcusID"].Value.ToString();
                workSheet.Cells[i + 4, 3] = guna2DataGridView1.Rows[i].Cells["dgvCustomer"].Value.ToString();
                workSheet.Cells[i + 4, 4] = guna2DataGridView1.Rows[i].Cells["dgvRoom"].Value.ToString();
                workSheet.Cells[i + 4, 5] = guna2DataGridView1.Rows[i].Cells["dgvIn"].Value.ToString();
                workSheet.Cells[i + 4, 6] = guna2DataGridView1.Rows[i].Cells["dgvOut"].Value.ToString();
                workSheet.Cells[i + 4, 7] = guna2DataGridView1.Rows[i].Cells["dgvDay"].Value.ToString();
                workSheet.Cells[i + 4, 8] = guna2DataGridView1.Rows[i].Cells["dgvAmount"].Value.ToString();
                workSheet.Cells[i + 4, 9] = guna2DataGridView1.Rows[i].Cells["dgvStatus"].Value.ToString();
                workSheet.Cells[i + 4, 10] = guna2DataGridView1.Rows[i].Cells["dgvRece"].Value.ToString();
            }

            // Définir une largeur automatique pour les colonnes
            workSheet.Columns.AutoFit();

            // Enregistrer le fichier Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workBook.SaveAs(saveFileDialog.FileName);
                workBook.Close();
                excelApp.Quit();
                guna2MessageDialog1.Show("Exportation réussie!");
            }
        }

    }
}
