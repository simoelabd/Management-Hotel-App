using HotelManagment.Model;
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
            ListBox lb = new ListBox();
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
        }
    }
}
