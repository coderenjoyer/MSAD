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
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 97);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
            label3.TabIndex = 7;
            label3.Text = "Document Retrieval Hub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 55.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 15);
            label2.Name = "label2";
            label2.Size = new Size(316, 87);
            label2.TabIndex = 6;
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
            pnlNavBar.BackColor = Color.Maroon;
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
            btnUsers.BackColor = SystemColors.Control;
            btnUsers.Dock = DockStyle.Left;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.Location = new Point(714, 0);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(238, 45);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1666, 0);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(238, 45);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.Control;
            btnHistory.Dock = DockStyle.Left;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(476, 0);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(238, 45);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnVerification
            // 
            btnVerification.BackColor = SystemColors.Control;
            btnVerification.Dock = DockStyle.Left;
            btnVerification.FlatStyle = FlatStyle.Flat;
            btnVerification.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerification.Location = new Point(238, 0);
            btnVerification.Margin = new Padding(3, 2, 3, 2);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(238, 45);
            btnVerification.TabIndex = 1;
            btnVerification.Text = "Verification";
            btnVerification.UseVisualStyleBackColor = false;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnDash
            // 
            btnDash.BackColor = SystemColors.Control;
            btnDash.Dock = DockStyle.Left;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDash.Location = new Point(0, 0);
            btnDash.Margin = new Padding(3, 2, 3, 2);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(238, 45);
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
        private Label label3;
        private Label label2;
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
    }
}