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
            btnLogout = new Button();
            btnHistory = new Button();
            btnVerification = new Button();
            btnDash = new Button();
            mainPanel = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            pblHeader.Name = "pblHeader";
            pblHeader.Size = new Size(1924, 200);
            pblHeader.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 129);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 7;
            label3.Text = "Document Retrieval Hub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 55.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 20);
            label2.Name = "label2";
            label2.Size = new Size(397, 109);
            label2.TabIndex = 6;
            label2.Text = "TekDok";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Cebu_Institute_of_Technology_University_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.Maroon;
            pnlNavBar.Controls.Add(btnLogout);
            pnlNavBar.Controls.Add(btnHistory);
            pnlNavBar.Controls.Add(btnVerification);
            pnlNavBar.Controls.Add(btnDash);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 200);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1924, 60);
            pnlNavBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1652, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(272, 60);
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
            btnHistory.Location = new Point(544, 0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(272, 60);
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
            btnVerification.Location = new Point(272, 0);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(272, 60);
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
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(272, 60);
            btnDash.TabIndex = 0;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 260);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1924, 795);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(mainPanel);
            Controls.Add(pnlNavBar);
            Controls.Add(pblHeader);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}