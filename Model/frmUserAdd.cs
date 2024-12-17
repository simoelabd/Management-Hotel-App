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
            string qry = "";
            if (id == 0) //Save
            {
                qry = @"INSERT INTO users (uName, uUsername, uPass, uPhone) 
                        VALUES (@uName, @uUsername, @uPass, @Phone)";
            }
            else //update
            {
                qry = @"Update users SET uName=@uName, uUsername=@uUsername ,uPass=@uPass ,uPhone=@Phone
                        where userID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@uName", txtName.Text);
            ht.Add("@uUsername", txtUsername.Text);
            ht.Add("@uPass", txtPass.Text);
            ht.Add("@Phone", txtPhone.Text);

            int r = MainClass.SQL(qry, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtName.Focus();


                guna2MessageDialog1.Show("Saved successfully");
                id = 0;

            }
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
