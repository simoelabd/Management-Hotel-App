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
    public partial class frmUserView : SampleView
    {
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd());
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
            lb.Items.Add(dgvUsername);
            lb.Items.Add(dgvPass);
            lb.Items.Add(dgvPhone);

            string qry = @"Select * from users where uName like '%" + txtSearch.Text + "%'";

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Code
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedite" && e.RowIndex != -1)
            {
                frmUserAdd frm = new frmUserAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtUsername.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUsername"].Value);
                frm.txtPass.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPass"].Value);
                frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);

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
                            string qry = @"Delete from users where userID =" + ID + " ";
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
