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
    public partial class pnlVerification : UserControl
    {
        public pnlVerification()
        {
            InitializeComponent();
        }

        private void pnlVerification_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT req_id, account_id, documenttype, reason, email FROM DocuRequest";

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
    }
}
