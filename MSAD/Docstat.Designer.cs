namespace MSAD
{
    partial class Docstat
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
            dgvhistory = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnupdate = new Button();
            label3 = new Label();
            txtemail = new TextBox();
            label2 = new Label();
            txtreason = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvhistory).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvhistory
            // 
            dgvhistory.AllowUserToAddRows = false;
            dgvhistory.AllowUserToDeleteRows = false;
            dgvhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhistory.BackgroundColor = Color.Maroon;
            dgvhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistory.GridColor = Color.Maroon;
            dgvhistory.Location = new Point(34, 108);
            dgvhistory.Name = "dgvhistory";
            dgvhistory.ReadOnly = true;
            dgvhistory.Size = new Size(782, 681);
            dgvhistory.TabIndex = 0;
            dgvhistory.CellClick += dgvhistory_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(465, 73);
            label1.TabIndex = 1;
            label1.Text = "Requests History";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnupdate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtreason);
            groupBox1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(878, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1009, 531);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update ";
            // 
            // btnupdate
            // 
            btnupdate.ForeColor = Color.White;
            btnupdate.Location = new Point(840, 451);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(146, 40);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 134);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(192, 134);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(446, 29);
            txtemail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 269);
            label2.Name = "label2";
            label2.Size = new Size(153, 22);
            label2.TabIndex = 1;
            label2.Text = "Reason of Request";
            // 
            // txtreason
            // 
            txtreason.Location = new Point(192, 269);
            txtreason.Multiline = true;
            txtreason.Name = "txtreason";
            txtreason.Size = new Size(794, 102);
            txtreason.TabIndex = 0;
            // 
            // Docstat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1919, 830);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvhistory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Docstat";
            Text = "Docstat";
            Load += Docstat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhistory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvhistory;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtreason;
        private Button btnupdate;
        private Label label3;
        private TextBox txtemail;
        private Label label2;
    }
}