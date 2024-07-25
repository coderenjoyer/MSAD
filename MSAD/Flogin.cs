using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
            loadform(new signin(this));
        }

        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            loadform(new AccountRegister());

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            loadform(new signin(this));
        }

        private void Flogin_Load(object sender, EventArgs e)
        {
            loadform(new signin(this));
        }

        private void ShowPanelForm()
        {
            signin signin = new signin(this);
            signin.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
