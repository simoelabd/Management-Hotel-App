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
    public partial class frmTypeAdd : SampleAdd
    {
        public frmTypeAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0) //Save
            {
                qry = @"INSERT INTO roomtype (tName, tDescription) 
                        VALUES (@tName, @tDescription)";
            }
            else //update
            {
                qry = @"Update roomtype SET tName=@tName, tDescription=@tDescription where typeID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@tName", txtName.Text);
            ht.Add("@tDescription", txtDesc.Text);

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
