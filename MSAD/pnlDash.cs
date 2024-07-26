using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MSAD
{
    public partial class pnlDash : UserControl
    {
        public pnlDash()
        {
            InitializeComponent();
        }

        private void pnlDash_Load(object sender, EventArgs e)
        {
            Loaddash();
            DataTable dt = Loaddash();

            if (dt != null)
            {
                int certificationcount = 0;
                int hondiscount = 0;
                int diplomacount = 0;
                int accrecount = 0;
                int gradecount = 0;
                int documentarycount = 0;
                int transciprtcount = 0;
                int scancount = 0;
                int photocopycount = 0;
                int mailingcount = 0;
                int cavcount = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string documentType = row["documenttype"].ToString();

                    switch (documentType)
                    {
                        case "Certification":
                            certificationcount++;
                            break;
                        case "Honorable Dismissal / Certificate of Transfer Credentials":
                            hondiscount++;
                            break;
                        case "Diploma":
                            diplomacount++;
                            break;
                        case "Accreditation Form / Completion Form":
                            accrecount++;
                            break;
                        case "Grades / Study Loads":
                            gradecount++;
                            break;
                        case "Documentary Stamp/s":
                            documentarycount++;
                            break;
                        case "Transcript of Records":
                            transciprtcount++;
                            break;
                        case "Scan":
                            scancount++;
                            break;
                        case "Photocopy":
                            photocopycount++;
                            break;
                        case "Mailing Expenses":
                            mailingcount++;
                            break;
                        case "C.A.V / Red Ribbon / Apostille":
                            cavcount++;
                            break;
                        default:
                            break;
                    }
                }

                lblcert.Text = certificationcount.ToString();
                lblhondis.Text = hondiscount.ToString();
                lbldip.Text = diplomacount.ToString();
                lblaccre.Text = accrecount.ToString();
                lblgrade.Text = gradecount.ToString();
                lbldoc.Text = documentarycount.ToString();
                lbltrans.Text = transciprtcount.ToString();
                lblscan.Text = scancount.ToString();
                lblphoto.Text = photocopycount.ToString();
                lblmail.Text = mailingcount.ToString();
                lblcav.Text = cavcount.ToString();
            }
            else
            {
                MessageBox.Show("Failed to load document data.");
            }
        }

        private DataTable Loaddash()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;Persist Security Info=True;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";
            string query = "SELECT req_id, account_id, documenttype, reason, email, stat FROM DocuRequest";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvReq.DataSource = dataTable;
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading document requests: " + ex.Message);
                return null;
            }
        }
    }
}
