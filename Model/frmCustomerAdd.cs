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
            // Vérification si les champs nécessaires sont vides
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                guna2MessageDialog1.Show("Please fill in all required fields.");
                return;
            }

            // Vérification si le nom, le téléphone ou l'email existent déjà
            string checkQuery = "SELECT COUNT(*) FROM customers WHERE cName = @cName OR cPhone = @cPhone OR cEmail = @cEmail";
            Hashtable checkParams = new Hashtable();
            checkParams.Add("@cName", txtName.Text);
            checkParams.Add("@cPhone", txtPhone.Text);
            checkParams.Add("@cEmail", txtEmail.Text);

            int existingCustomers = Convert.ToInt32(MainClass.SQL(checkQuery, checkParams));

            if (existingCustomers > 0)
            {
                guna2MessageDialog1.Show("A customer with this name, phone number, or email already exists.");
                return;
            }

            string qry = "";
            if (id == 0) // Save
            {
                qry = @"INSERT INTO customers (cName, cPhone, cEmail) 
                VALUES (@cName, @cPhone, @cEmail)";
            }
            else // Update
            {
                qry = @"UPDATE customers SET cName = @cName, cPhone = @cPhone, cEmail = @cEmail
                WHERE cusID = @id";
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
