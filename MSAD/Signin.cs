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
        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAdmin;

            if (ValidateLogin(txtschID.Text, txtpass.Text, out isAdmin))
            {
                MessageBox.Show("Login successful!");

                if (isAdmin)
                {
                    Admin adminHome = new Admin();
                    adminHome.Show();
                }
                else
                {
                    UserHome userHome = new UserHome();
                    userHome.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user ID or password.");
            }
        }

        private bool ValidateLogin(string username, string password, out bool isAdmin)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            isAdmin = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    if (username.ToLower() == "admin")
                    {
                        string adminQuery = "SELECT COUNT(1) FROM [Accs] WHERE [username] = @Username AND [pass] = @Password";
                        using (SqlCommand adminCommand = new SqlCommand(adminQuery, connection))
                        {
                            adminCommand.Parameters.AddWithValue("@Username", username);
                            adminCommand.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(adminCommand.ExecuteScalar());

                            isAdmin = count == 1;
                            return isAdmin;
                        }
                    }
                    else
                    {
                        string userQuery = "SELECT COUNT(1) FROM [Accs] WHERE [username] = @Username AND [pass] = @Password";
                        using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                        {
                            userCommand.Parameters.AddWithValue("@Username", username);
                            userCommand.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(userCommand.ExecuteScalar());
                            return count == 1;
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
