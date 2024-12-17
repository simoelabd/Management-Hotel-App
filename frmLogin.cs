using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(MainClass.IsValidUser(txtUsername.Text, txtPass.Text) == false)
            {
                MessageBox.Show("Invalid User Details! ");
                return;
            }

            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
