using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MSAD
{
    public partial class AccountRegister : Form
    {
        public AccountRegister()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (InsertIntoAccountsAndProfile())
            {
                MessageBox.Show("Registration successful!");
                Flogin flogin = new Flogin();
                flogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }


        private bool InsertIntoAccountsAndProfile()
        {
            string connectionString = "Data Source=tekdoc.database.windows.net;Initial Catalog=TekDoc;User ID=khalil.peque@cit.edu;Password=Miakhally311;Encrypt=True;Authentication=ActiveDirectoryPassword";

            string insertAccountQuery = "INSERT INTO [Accs] ([username], [pass]) VALUES (@Username, @Password); SELECT SCOPE_IDENTITY();";
            string insertProfileQuery = "INSERT INTO [UserProfile] ([account_id], [last_name], [first_name], [middle_name], [classif], [dept], [prog], [yrlvl], [profi]) VALUES (@AccountId, @LastName, @FirstName, @MI, @Classif, @Depart, @Prog, @YrLvl, @Profi)";

            
            if (string.IsNullOrWhiteSpace(userID.Text) || string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(lastname.Text) || string.IsNullOrWhiteSpace(firstname.Text) ||
                string.IsNullOrWhiteSpace(mi.Text) || cmbdept.SelectedItem == null ||
                cmbclassif.SelectedItem == null || string.IsNullOrWhiteSpace(program.Text) ||
                yearlevel.SelectedItem == null || profile.Image == null)
            {
                MessageBox.Show("All fields must be filled out.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        int accountId;
                        using (SqlCommand command = new SqlCommand(insertAccountQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Username", userID.Text);
                            command.Parameters.AddWithValue("@Password", password.Text);

                            accountId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        using (SqlCommand command = new SqlCommand(insertProfileQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@AccountId", accountId);
                            command.Parameters.AddWithValue("@LastName", lastname.Text);
                            command.Parameters.AddWithValue("@FirstName", firstname.Text);
                            command.Parameters.AddWithValue("@MI", mi.Text);
                            command.Parameters.AddWithValue("@Classif", cmbclassif.Text);
                            command.Parameters.AddWithValue("@Depart", cmbdept.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Prog", program.Text);
                            command.Parameters.AddWithValue("@YrLvl", yearlevel.SelectedItem.ToString());

                           
                            byte[] photoData = ConvertPhotoToByteArray(profile.Image); 
                            command.Parameters.AddWithValue("@Profi", photoData);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while registering: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                return false;
            }
        }

        private byte[] ConvertPhotoToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }


        private void profile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profile.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            profile_Click(sender, e);
        }

        private bool isPasswordVisible = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                password.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.view;
            }
            else
            {
                password.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.hide;
            }
            isPasswordVisible = !isPasswordVisible;
        }

        private bool isConPasswordVisible = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isConPasswordVisible)
            {
                conpassword.PasswordChar = '*';
                pictureBox2.Image = Properties.Resources.view;
            }
            else
            {
                conpassword.PasswordChar = '\0';
                pictureBox2.Image = Properties.Resources.hide;
            }
            isConPasswordVisible = !isConPasswordVisible;
        }
    }
}
