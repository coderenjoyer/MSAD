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
    public partial class pnlHistory : UserControl
    {
        public pnlHistory()
        {
            InitializeComponent();
        }

        private void pnlHistory_Load(object sender, EventArgs e)
        {
            Loadhistory();
        }

        private void Loadhistory()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT req_id, account_id, documenttype, reason, email, stat FROM DocuRequest";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvhistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading document history: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvhistory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvhistory.SelectedRows[0];
                int reqId = Convert.ToInt32(selectedRow.Cells["req_id"].Value);

                string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;Persist Security Info=True;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
                string query = "DELETE FROM DocuRequest WHERE req_id = @ReqId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ReqId", reqId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Request deleted successfully.");
                                Loadhistory();  
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified request ID.");
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

