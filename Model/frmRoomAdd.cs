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
    public partial class frmRoomAdd : SampleAdd
    {
        public frmRoomAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int typeID = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            // Vérification si les champs nécessaires sont vides
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrix.Text) || string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                guna2MessageDialog1.Show("Please fill in all required fields.");
                return;
            }

            // Vérification si le nom de la chambre existe déjà
            string checkQuery = "SELECT COUNT(*) FROM room WHERE rName = @rName";
            Hashtable checkParams = new Hashtable();
            checkParams.Add("@rName", txtName.Text);

            int existingRooms = Convert.ToInt32(MainClass.SQL(checkQuery, checkParams));

            if (existingRooms > 0)
            {
                guna2MessageDialog1.Show("A room with this name already exists.");
                return;
            }

            string qry = "";
            if (id == 0) // Save
            {
                qry = @"INSERT INTO room (rName, rTypeID, rPrix, rStatus) 
                VALUES (@rName, @rTypeID, @rPrix, @rStatus)";
            }
            else // Update
            {
                qry = @"UPDATE room SET rName = @rName, rTypeID = @rTypeID, rPrix = @rPrix, rStatus = @rStatus
                WHERE roomID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@rName", txtName.Text);
            ht.Add("@rTypeID", Convert.ToInt32(cbType.SelectedValue));
            ht.Add("@rPrix", Convert.ToDouble(txtPrix.Text));
            ht.Add("@rStatus", cbStatus.Text);

            int r = MainClass.SQL(qry, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtName.Focus();
                guna2MessageDialog1.Show("Room Saved successfully");
                id = 0;
            }
            else
            {
                guna2MessageDialog1.Show("Operation failed. Please try again.");
            }
        }


        private void frmRoomAdd_Load(object sender, EventArgs e)
        {
            string qry = @"Select typeID 'id' , tName 'name' from roomtype ";
            MainClass.CBFill(qry, cbType);

            if (id > 0)
            {
                cbType.SelectedValue = typeID;
            }
        }
    }
}