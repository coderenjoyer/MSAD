using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSAD
{
    public partial class Admin : Form
    {
        pnlDash pnlDash = new pnlDash();
        pnlVerification pnlVerification = new pnlVerification();
        pnlHistory pnlHistory = new pnlHistory();
        pnlUsers pnlUsers = new pnlUsers();

        public Admin()
        {
            InitializeComponent();
        }

        private void lblReq_Click(object sender, EventArgs e)
        {

        }

        private void lblReq_Click_1(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.Gold;
            mainPanel.Controls.Add(pnlDash);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            btnClearColor();
            btnDash.BackColor = Color.Gold;


            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pnlDash);
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            btnClearColor();
            btnVerification.BackColor = Color.Gold;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pnlVerification);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnClearColor();
            btnHistory.BackColor = Color.Gold;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pnlHistory);
        }


        private void btnClearColor()
        {
            btnDash.BackColor = SystemColors.Window;
            btnVerification.BackColor = SystemColors.Window;
            btnHistory.BackColor = SystemColors.Window;
            btnUsers.BackColor = SystemColors.Window;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Flogin flogin = new Flogin();
            flogin.Show();
            this.Close();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnClearColor();
            btnUsers.BackColor = Color.Gold;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pnlUsers);
        }
    }
}
