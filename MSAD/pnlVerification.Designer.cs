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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvdocureq).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(351, 34);
            label1.TabIndex = 3;
            label1.Text = "Verification Page";
            // 
            // dgvdocureq
            // 
            dgvdocureq.AllowUserToAddRows = false;
            dgvdocureq.AllowUserToDeleteRows = false;
            dgvdocureq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdocureq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdocureq.Location = new Point(858, 101);
            dgvdocureq.Name = "dgvdocureq";
            dgvdocureq.ReadOnly = true;
            dgvdocureq.Size = new Size(1005, 713);
            dgvdocureq.TabIndex = 4;
            dgvdocureq.CellClick += dgvdocureq_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(858, 72);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Pending Requests";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(18, 134);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(466, 23);
            txtemail.TabIndex = 6;
            // 
            // txtmsg
            // 
            txtmsg.Location = new Point(18, 395);
            txtmsg.Multiline = true;
            txtmsg.Name = "txtmsg";
            txtmsg.Size = new Size(802, 173);
            txtmsg.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 377);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 9;
            label4.Text = "Body";
            // 
            // txtreason
            // 
            txtreason.Location = new Point(18, 203);
            txtreason.Multiline = true;
            txtreason.Name = "txtreason";
            txtreason.Size = new Size(802, 122);
            txtreason.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 185);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "Reason of Request";
            // 
            // btnsendemail
            // 
            btnsendemail.Location = new Point(18, 708);
            btnsendemail.Name = "btnsendemail";
            btnsendemail.Size = new Size(114, 36);
            btnsendemail.TabIndex = 12;
            btnsendemail.Text = "Accept";
            btnsendemail.UseVisualStyleBackColor = true;
            btnsendemail.Click += btnsendemail_Click;
            // 
            // btnreject
            // 
            btnreject.Location = new Point(154, 708);
            btnreject.Name = "btnreject";
            btnreject.Size = new Size(114, 36);
            btnreject.TabIndex = 13;
            btnreject.Text = "Reject";
            btnreject.UseVisualStyleBackColor = true;
            btnreject.Click += btnreject_Click;
            // 
            // txtaccid
            // 
            txtaccid.Location = new Point(18, 72);
            txtaccid.Name = "txtaccid";
            txtaccid.Size = new Size(36, 23);
            txtaccid.TabIndex = 14;
            txtaccid.Visible = false;
            // 
            // pnlVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtaccid);
            Controls.Add(btnreject);
            Controls.Add(btnsendemail);
            Controls.Add(label5);
            Controls.Add(txtreason);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtmsg);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(dgvdocureq);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnlVerification";
            Size = new Size(1904, 846);
            Load += pnlVerification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdocureq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
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
    }
}
