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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace MSAD
{
    public partial class userdashboard : Form
    {
        private int accountId;

        public userdashboard(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
        }

        private void userdashboard_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT last_name, first_name, middle_name, classif, dept, prog, yrlvl, profi FROM UserProfile WHERE account_id = @AccId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccId", accountId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lbllastn.Text = reader["last_name"].ToString();
                                lblfirstn.Text = reader["first_name"].ToString();
                                lblmi.Text = reader["middle_name"].ToString();
                                lblclassif.Text = reader["classif"].ToString();
                                lbldepart.Text = reader["dept"].ToString();
                                lblprog.Text = reader["prog"].ToString();
                                lblyrlvl.Text = reader["yrlvl"].ToString();

                                byte[] photoData = (byte[])reader["profi"];
                                if (photoData != null && photoData.Length > 0)
                                {
                                    using (var ms = new System.IO.MemoryStream(photoData))
                                    {
                                        profile.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the user profile: " + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "INSERT INTO [DocuRequest] (account_id, documenttype, reason, email, stat) VALUES (@AccId, @DocumentType, @Reason, @Email, @Stat)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccId", accountId);
                        command.Parameters.AddWithValue("@DocumentType", cmbdocutype.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Reason", txtreason.Text);
                        command.Parameters.AddWithValue("@Email", txtemail.Text);
                        command.Parameters.AddWithValue("@Stat", txtstat.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Document request submitted successfully.");
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit the document request.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the document request: " + ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            CancelMostRecentRequest();
        }

        private void CancelMostRecentRequest()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string selectQuery = "SELECT TOP 1 req_id FROM DocuRequest WHERE account_id = @AccId ORDER BY req_id DESC";
            string updateQuery = "UPDATE DocuRequest SET stat = 'Cancelled' WHERE req_id = @RequestId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int mostRecentRequestId = -1;

                    // Find the most recent request
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@AccId", accountId);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mostRecentRequestId = reader.GetInt32(0);
                            }
                        }
                    }

                    if (mostRecentRequestId != -1)
                    {
                        // Update the status of the most recent request
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@RequestId", mostRecentRequestId);

                            int result = updateCommand.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("The most recent document request has been cancelled successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel the most recent document request.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No document requests found to cancel.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while cancelling the document request: " + ex.Message);
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void ClearFormFields()
        {
            cmbdocutype.SelectedIndex = -1;
            txtreason.Clear();
            txtemail.Clear();
            txtstat.Clear();
        }
    }
}
