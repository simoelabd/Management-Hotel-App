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
    public partial class frmCustomerView : SampleView
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerAdd());
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
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvEmail);

            string qry = @"Select * from customers where cName like '%" + txtSearch.Text + "%'";

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Code
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedite" && e.RowIndex != -1)
            {
                frmCustomerAdd frm = new frmCustomerAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.txtEmail.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvEmail"].Value);

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
                            string qry = @"Delete from customers where cusID =" + ID + " ";
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
