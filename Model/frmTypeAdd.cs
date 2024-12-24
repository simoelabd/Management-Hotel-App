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
            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                guna2MessageDialog1.Show("Name field cannot be empty.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                guna2MessageDialog1.Show("Description field cannot be empty.");
                txtDesc.Focus();
                return;
            }

            // Vérification des doublons pour le nom
            string checkQry = "SELECT COUNT(*) FROM roomtype WHERE tName = @tName AND typeID = @id";
            Hashtable checkHt = new Hashtable
            {
                { "@tName", txtName.Text },
                { "@id", id }
            };

            int count = (int)MainClass.SQL(checkQry, checkHt);

            if (count > 0)
            {
                guna2MessageDialog1.Show("Name already exists. Please use a different name.");
                txtName.Focus();
                return;
            }

            // Requête SQL pour sauvegarder ou mettre à jour les données
            string qry = "";
            if (id == 0) // Nouveau enregistrement
            {
                qry = @"INSERT INTO roomtype (tName, tDescription) 
                VALUES (@tName, @tDescription)";
            }
            else // Mise à jour
            {
                qry = @"UPDATE roomtype SET tName=@tName, tDescription=@tDescription WHERE typeID = @id";
            }

            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@tName", txtName.Text },
                { "@tDescription", txtDesc.Text }
            };

            // Exécution de la requête
            int r = MainClass.SQL(qry, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtName.Focus();
                guna2MessageDialog1.Show("Saved successfully");
                id = 0;
            }
            else
            {
                guna2MessageDialog1.Show("Operation failed. Please try again.");
            }
        }


    }
}
