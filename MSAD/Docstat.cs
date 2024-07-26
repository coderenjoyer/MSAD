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
    public partial class Docstat : Form
    {
        private int accountId;
        public int indexRow;
        public Docstat(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
        }


        private void Docstat_Load(object sender, EventArgs e)
        {
            HistoryLoad();
        }

        private void HistoryLoad()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT req_id, account_id, documenttype, reason, email, stat FROM DocuRequest WHERE account_id = @AccId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@AccId", accountId);

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

        private void dgvhistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvhistory.Rows[indexRow];

                txtemail.Text = row.Cells["email"].Value?.ToString();
                txtreason.Text = row.Cells["reason"].Value?.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateRequest();
        }

        private void UpdateRequest()
        {
            if (indexRow >= 0)
            {
                DataGridViewRow row = dgvhistory.Rows[indexRow];
                string currentStatus = row.Cells["stat"].Value?.ToString();

                if (currentStatus == "Pending")
                {
                    int reqId = Convert.ToInt32(row.Cells["req_id"].Value);
                    string updatedEmail = txtemail.Text;
                    string updatedReason = txtreason.Text;

                    string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
                    string updateQuery = "UPDATE DocuRequest SET email = @Email, reason = @Reason WHERE req_id = @ReqId AND stat = 'Pending'";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Email", updatedEmail);
                                command.Parameters.AddWithValue("@Reason", updatedReason);
                                command.Parameters.AddWithValue("@ReqId", reqId);

                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Document request updated successfully.");
                                    HistoryLoad(); 
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the document request. Make sure the status is 'Pending'.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the document request: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Only requests with status 'Pending' can be updated.");
                }
            }
        }
    }
}
