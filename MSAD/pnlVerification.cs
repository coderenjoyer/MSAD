﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Drawing2D;

namespace MSAD
{
    public partial class pnlVerification : UserControl
    {
        public int indexRow;
        public pnlVerification()
        {
            InitializeComponent();
            pnlEmail.Paint += Panel_Paint;
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Get the rectangle representing the bounds of the panel
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                // Set the radius for rounded corners based on the panel's size
                int radius = Math.Min(panel.Width, panel.Height) / 12; // Increase the divisor for less rounded corners

                // Create a graphics path for rounded corners
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Apply the graphics path to the panel's region
                panel.Region = new Region(path);
            }
        }


        private void Loaddata()
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
                    dgvdocureq.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading document requests: " + ex.Message);
            }
        }

        private void pnlVerification_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dgvdocureq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvdocureq.Rows[indexRow];

                txtaccid.Text = row.Cells["account_id"].Value?.ToString();
                txtemail.Text = row.Cells["email"].Value?.ToString();
                txtreason.Text = row.Cells["reason"].Value?.ToString();
            }
        }

        private void btnsendemail_Click(object sender, EventArgs e)
        {
            SendEmail();
            UpdateDatabaseStatus("Approved");
            Loaddata();
        }

        private void SendEmail()
        {
            string toEmail = txtemail.Text;
            string messageBody = txtmsg.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(toEmail) || string.IsNullOrWhiteSpace(messageBody))
            {
                MessageBox.Show("Please fill out both the email and the message fields.");
                return;
            }

            // Validate the email address format
            if (!IsValidEmail(toEmail))
            {
                MessageBox.Show("The email address provided is not valid.");
                return;
            }

            try
            {
                // Configure the email
                using (MailMessage mail = new MailMessage("texkdocretrieval@gmail.com", toEmail))
                {
                    mail.Subject = "Subject";
                    mail.Body = messageBody;

                    // Configure the SMTP client (Gmail SMTP server)
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("texkdocretrieval@gmail.com", "pfpk eniq lhpu sakh"); // Replace with your app password
                        client.EnableSsl = true;

                        // Send the email
                        client.Send(mail);
                    }
                }

                MessageBox.Show("Email sent successfully!");
            }
            catch (SmtpException smtpEx)
            {
                // Detailed error message for SMTP issues
                MessageBox.Show($"SMTP error sending email: {smtpEx.Message}\n{smtpEx.StackTrace}");
                LogError(smtpEx);  // Log error details for further investigation
            }
            catch (Exception ex)
            {
                // General error handling
                MessageBox.Show($"General error sending email: {ex.Message}\n{ex.StackTrace}");
                LogError(ex);  // Log error details for further investigation
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LogError(Exception ex)
        {
            // Simple logging example; you may want to use a more robust logging framework
            System.IO.File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
        }

        private void UpdateDatabaseStatus(string status)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "UPDATE DocuRequest SET stat = @Status WHERE account_id = @AccId";

            // Retrieve the account_id from the relevant source, for example, a TextBox
            int accountId;
            if (!int.TryParse(txtaccid.Text, out accountId))
            {
                MessageBox.Show("Invalid account ID.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@AccId", accountId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Database updated to {status} successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified account ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating database: {ex.Message}\n{ex.StackTrace}");
                LogError(ex);
            }
        }

        private void btnreject_Click(object sender, EventArgs e)
        {

        }
    }
}

