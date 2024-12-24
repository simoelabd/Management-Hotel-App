using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace HotelManagment
{
    internal class MainClass
    {
        // For connection string      
        public static readonly string cons = "Server=localhost;uid=root;Database=managehotel;";
        public static MySqlConnection con = new MySqlConnection(cons);

        // for active user 
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        //for valid user
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = "SELECT * FROM users WHERE uUsername = @user AND uPass = @pass";

            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isValid;
        }

        // for blur background
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = System.Drawing.Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        // for loading data from database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        public static void gv_CellFormatting(Object sender, DataGridViewCellFormattingEventArgs e)
        {
            var gv = (DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // for insert, update, delete
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, con);

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }

        // for combobox fill
        public static void CBFill(string qry, ComboBox cb)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // to clean form fields
        public static void ClearAll(Form F)
        {
            foreach (Control c in F.Controls)
            {
                Type type = c.GetType();

                if (type == typeof(Guna2TextBox))
                {
                    ((Guna2TextBox)c).Text = "";
                }
                else if (type == typeof(Guna2ComboBox))
                {
                    ((Guna2ComboBox)c).SelectedIndex = -1;
                }
                else if (type == typeof(Guna2CheckBox))
                {
                    ((Guna2CheckBox)c).Checked = false;
                }
                // you can add other controls like this
            }
        }
    }
}