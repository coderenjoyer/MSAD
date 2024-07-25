using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MSAD
{
    public partial class signin : Form
    {
        private Flogin _mainForm;

        public signin(Flogin mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT account_id, username FROM [Accs] WHERE username = @Username AND pass = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", txtschID.Text);
                        command.Parameters.AddWithValue("@Password", txtpass.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int accountId = reader.GetInt32(0);
                                string username = reader.GetString(1);

                                MessageBox.Show("Login successful!");

                                if (username == "admin")
                                {
                                    Admin adminHome = new Admin();
                                    adminHome.Show();
                                }
                                else
                                {
                                    UserHome userHome = new UserHome(accountId);
                                    userHome.Show();
                                }

                                this.Hide();
                                _mainForm.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid user ID or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating the login: " + ex.Message);
            }
        }
    }
}
        /*private bool ValidateLogin(string username, string password, out bool isAdmin, out int? profileId)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = @"
        SELECT A.[username], 
               CASE 
                   WHEN A.[username] = 'admin' THEN 1 
                   ELSE 0 
               END AS IsAdmin,
               UP.[profile_id]
        FROM [Accs] A
        LEFT JOIN [UserProfile] UP ON A.[account_id] = UP.[account_id]
        WHERE A.[username] = @Username AND A.[pass] = @Password";

            isAdmin = false;
            profileId = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isAdmin = reader.GetInt32(reader.GetOrdinal("IsAdmin")) == 1;
                                profileId = reader.IsDBNull(reader.GetOrdinal("profile_id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("profile_id"));
                                return true; // Login is successful
                            }
                            else
                            {
                                return false; // Invalid username or password
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating the login: " + ex.Message);
                return false;
            }
        }
    }
}
*/