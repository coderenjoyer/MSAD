namespace MSAD
{
    partial class pnlVerification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlVerification));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvdocureq = new DataGridView();
            label2 = new Label();
            txtemail = new TextBox();
            txtmsg = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtreason = new TextBox();
            label5 = new Label();
            btnsendemail = new Button();
            btnreject = new Button();
            txtaccid = new TextBox();
            label1 = new Label();
            pnlEmail = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdocureq).BeginInit();
            pnlEmail.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvdocureq
            // 
            dgvdocureq.AllowUserToAddRows = false;
            dgvdocureq.AllowUserToDeleteRows = false;
            dgvdocureq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdocureq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdocureq.Location = new Point(874, 54);
            dgvdocureq.Name = "dgvdocureq";
            dgvdocureq.ReadOnly = true;
            dgvdocureq.Size = new Size(1005, 713);
            dgvdocureq.TabIndex = 4;
            dgvdocureq.CellClick += dgvdocureq_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(874, 9);
            label2.Name = "label2";
            label2.Size = new Size(263, 39);
            label2.TabIndex = 5;
            label2.Text = "Pending Requests:";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(16, 102);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(466, 29);
            txtemail.TabIndex = 6;
            // 
            // txtmsg
            // 
            txtmsg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmsg.Location = new Point(16, 423);
            txtmsg.Multiline = true;
            txtmsg.Name = "txtmsg";
            txtmsg.Size = new Size(802, 173);
            txtmsg.TabIndex = 7;
            txtmsg.Text = resources.GetString("txtmsg.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 15.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 15.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 387);
            label4.Name = "label4";
            label4.Size = new Size(74, 31);
            label4.TabIndex = 9;
            label4.Text = "Body:";
            // 
            // txtreason
            // 
            txtreason.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtreason.Location = new Point(16, 191);
            txtreason.Multiline = true;
            txtreason.Name = "txtreason";
            txtreason.Size = new Size(802, 122);
            txtreason.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 15.75F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(218, 31);
            label5.TabIndex = 11;
            label5.Text = "Reason of Request:";
            // 
            // btnsendemail
            // 
            btnsendemail.BackColor = Color.Gold;
            btnsendemail.FlatStyle = FlatStyle.Flat;
            btnsendemail.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            btnsendemail.Location = new Point(695, 621);
            btnsendemail.Name = "btnsendemail";
            btnsendemail.Size = new Size(114, 46);
            btnsendemail.TabIndex = 12;
            btnsendemail.Text = "Accept";
            btnsendemail.UseVisualStyleBackColor = false;
            btnsendemail.Click += btnsendemail_Click;
            // 
            // btnreject
            // 
            btnreject.BackColor = Color.Gold;
            btnreject.FlatStyle = FlatStyle.Flat;
            btnreject.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            btnreject.Location = new Point(575, 621);
            btnreject.Name = "btnreject";
            btnreject.Size = new Size(114, 46);
            btnreject.TabIndex = 13;
            btnreject.Text = "Reject";
            btnreject.UseVisualStyleBackColor = false;
            btnreject.Click += btnreject_Click;
            // 
            // txtaccid
            // 
            txtaccid.Location = new Point(102, 73);
            txtaccid.Name = "txtaccid";
            txtaccid.Size = new Size(36, 23);
            txtaccid.TabIndex = 14;
            txtaccid.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 352);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 15;
            label1.Text = "Send an Email";
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.Maroon;
            pnlEmail.Controls.Add(label6);
            pnlEmail.Controls.Add(txtemail);
            pnlEmail.Controls.Add(label1);
            pnlEmail.Controls.Add(txtmsg);
            pnlEmail.Controls.Add(txtaccid);
            pnlEmail.Controls.Add(label3);
            pnlEmail.Controls.Add(btnreject);
            pnlEmail.Controls.Add(label4);
            pnlEmail.Controls.Add(btnsendemail);
            pnlEmail.Controls.Add(txtreason);
            pnlEmail.Controls.Add(label5);
            pnlEmail.Location = new Point(18, 56);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(839, 708);
            pnlEmail.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(257, 22);
            label6.Name = "label6";
            label6.Size = new Size(324, 44);
            label6.TabIndex = 16;
            label6.Text = "Request Information";
            // 
            // pnlVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            Controls.Add(pnlEmail);
            Controls.Add(label2);
            Controls.Add(dgvdocureq);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnlVerification";
            Size = new Size(1904, 846);
            Load += pnlVerification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdocureq).EndInit();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvdocureq;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtmsg;
        private Label label3;
        private Label label4;
        private TextBox txtreason;
        private Label label5;
        private Button btnsendemail;
        private Button btnreject;
        private TextBox txtaccid;
        private Label label1;
        private Panel pnlEmail;
        private Label label6;
    }
}
