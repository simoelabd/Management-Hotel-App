using MySql.Data.MySqlClient;
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
    public partial class frmDashboard : Sample
    {
        string connectionString = "Server=localhost;uid=root;Database=managehotel;";
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalReservations();
            LoadTotalChambres();
            LoadTotalClients();
            LoadTotalUsers();
        }

        private void LoadTotalReservations()
        {
            try
            {
                // Connexion à la base de données
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Requête SQL pour compter les réservations
                    string query = "SELECT COUNT(*) FROM bookings";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Exécuter la requête
                        int totalReservations = Convert.ToInt32(cmd.ExecuteScalar());

                        // Afficher le résultat dans le Label
                        totalReservation.Text = totalReservations.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalChambres()
        {
            try
            {
                // Connexion à la base de données
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Requête SQL pour compter les réservations
                    string query = "SELECT COUNT(*) FROM room";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Exécuter la requête
                        int totalReservations = Convert.ToInt32(cmd.ExecuteScalar());

                        // Afficher le résultat dans le Label
                        totalChambres.Text = totalReservations.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalClients()
        {
            try
            {
                // Connexion à la base de données
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Requête SQL pour compter les réservations
                    string query = "SELECT COUNT(*) FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Exécuter la requête
                        int totalReservations = Convert.ToInt32(cmd.ExecuteScalar());

                        // Afficher le résultat dans le Label
                        totalClients.Text = totalReservations.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalUsers()
        {
            try
            {
                // Connexion à la base de données
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Requête SQL pour compter les réservations
                    string query = "SELECT COUNT(*) FROM users";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Exécuter la requête
                        int totalReservations = Convert.ToInt32(cmd.ExecuteScalar());

                        // Afficher le résultat dans le Label
                        totalUsers.Text = totalReservations.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
