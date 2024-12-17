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
    public partial class frmCustomerAdd : SampleAdd
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0) //Save
            {
                qry = @"INSERT INTO customers (cName, cPhone, cEmail) 
                        VALUES (@cName, @cPhone, @cEmail)";
            }
            else //update
            {
                qry = @"Update customers SET cName=@cName, cPhone=@cPhone ,cEmail=@cEmail where cusID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@cName", txtName.Text);
            ht.Add("@cPhone", txtPhone.Text);
            ht.Add("@cEmail", txtEmail.Text);

            int r = MainClass.SQL(qry, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtName.Focus();


                guna2MessageDialog1.Show("Saved successfully");
                id = 0;

            }
        }
    }
}
