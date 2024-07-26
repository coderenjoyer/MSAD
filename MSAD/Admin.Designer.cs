namespace MSAD
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pblHeader = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlNavBar = new Panel();
            btnUsers = new Button();
            btnLogout = new Button();
            btnHistory = new Button();
            btnVerification = new Button();
            btnDash = new Button();
            mainPanel = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            pblHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // pblHeader
            // 
            pblHeader.Controls.Add(label3);
            pblHeader.Controls.Add(label2);
            pblHeader.Controls.Add(pictureBox1);
            pblHeader.Dock = DockStyle.Top;
            pblHeader.Location = new Point(0, 0);
            pblHeader.Margin = new Padding(3, 2, 3, 2);
            pblHeader.Name = "pblHeader";
            pblHeader.Size = new Size(1904, 150);
            pblHeader.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 106);
            label3.Name = "label3";
            label3.Size = new Size(243, 24);
            label3.TabIndex = 9;
            label3.Text = "Document Retrieval Hub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pristina", 69.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(195, 15);
            label2.Name = "label2";
            label2.Size = new Size(302, 122);
            label2.TabIndex = 8;
            label2.Text = "TekDok";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Cebu_Institute_of_Technology_University_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 150);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.Gold;
            pnlNavBar.BorderStyle = BorderStyle.FixedSingle;
            pnlNavBar.Controls.Add(btnUsers);
            pnlNavBar.Controls.Add(btnLogout);
            pnlNavBar.Controls.Add(btnHistory);
            pnlNavBar.Controls.Add(btnVerification);
            pnlNavBar.Controls.Add(btnDash);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 150);
            pnlNavBar.Margin = new Padding(3, 2, 3, 2);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1904, 45);
            pnlNavBar.TabIndex = 1;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Maroon;
            btnUsers.Dock = DockStyle.Left;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Sitka Small", 14.25F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(709, 0);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(238, 43);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Maroon;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1664, 0);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(238, 43);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Maroon;
            btnHistory.Dock = DockStyle.Left;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Sitka Small", 14.25F);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(471, 0);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(238, 43);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnVerification
            // 
            btnVerification.BackColor = Color.Maroon;
            btnVerification.Dock = DockStyle.Left;
            btnVerification.FlatStyle = FlatStyle.Flat;
            btnVerification.Font = new Font("Sitka Small", 14.25F);
            btnVerification.ForeColor = Color.White;
            btnVerification.Location = new Point(245, 0);
            btnVerification.Margin = new Padding(3, 2, 3, 2);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(226, 43);
            btnVerification.TabIndex = 1;
            btnVerification.Text = "Verification";
            btnVerification.UseVisualStyleBackColor = false;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.Maroon;
            btnDash.Dock = DockStyle.Left;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Sitka Small", 14.25F);
            btnDash.ForeColor = Color.White;
            btnDash.Location = new Point(0, 0);
            btnDash.Margin = new Padding(3, 2, 3, 2);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(245, 43);
            btnDash.TabIndex = 0;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 195);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 846);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainPanel);
            Controls.Add(pnlNavBar);
            Controls.Add(pblHeader);
            Name = "Admin";
            Text = "admin";
            Load += Admin_Load;
            pblHeader.ResumeLayout(false);
            pblHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pblHeader;
        private Panel pnlNavBar;
        private PictureBox pictureBox1;
        private Button btnDash;
        private Button btnHistory;
        private Button btnVerification;
        private Button btnLogout;
        private Panel mainPanel;
        private Label lblReq;
        private DataGridView dgvReq;
        private Label label5;
        private Label label4;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label15;
        private Label label14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnUsers;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label3;
        private Label label2;
    }
}