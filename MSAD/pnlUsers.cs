using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSAD
{
    public partial class pnlUsers : UserControl
    {
        public pnlUsers()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlUsers_Load(object sender, EventArgs e)
        {
            Loadusers();
        }

        private void Loadusers()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT account_id, username, pass FROM Accs";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvusers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred" + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvusers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvusers.SelectedRows[0];
                int AccID = Convert.ToInt32(selectedRow.Cells["account_id"].Value);

                string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";

                // SQL queries to delete related records
                string deleteDocuRequestQuery = "DELETE FROM DocuRequest WHERE account_id = @AccID";
                string deleteUserProfileQuery = "DELETE FROM UserProfile WHERE account_id = @AccID";
                string deleteAccsQuery = "DELETE FROM Accs WHERE account_id = @AccID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Delete related records in DocuRequest
                                using (SqlCommand command = new SqlCommand(deleteDocuRequestQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@AccID", AccID);
                                    command.ExecuteNonQuery();
                                }

                                // Delete related records in UserProfile
                                using (SqlCommand command = new SqlCommand(deleteUserProfileQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@AccID", AccID);
                                    command.ExecuteNonQuery();
                                }

                                // Delete the user record in Accs
                                using (SqlCommand command = new SqlCommand(deleteAccsQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@AccID", AccID);
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("User removed.");
                                        transaction.Commit();
                                        Loadusers();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No record found with the specified account ID.");
                                        transaction.Rollback();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Error deleting request: {ex.Message}\n{ex.StackTrace}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting request: {ex.Message}\n{ex.StackTrace}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }
}
