namespace MSAD
{
    partial class signin
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtpass = new TextBox();
            txtschID = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Maroon;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpass);
            groupBox1.Controls.Add(txtschID);
            groupBox1.Location = new Point(678, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 475);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 115);
            label4.Name = "label4";
            label4.Size = new Size(442, 15);
            label4.TabIndex = 6;
            label4.Text = "_______________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 37);
            label3.Name = "label3";
            label3.Size = new Size(415, 59);
            label3.TabIndex = 5;
            label3.Text = "User Authentication";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(156, 393);
            button1.Name = "button1";
            button1.Size = new Size(166, 44);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 267);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 166);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 2;
            label1.Text = "School ID:";
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(58, 314);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(367, 33);
            txtpass.TabIndex = 1;
            txtpass.TextAlign = HorizontalAlignment.Center;
            txtpass.UseSystemPasswordChar = true;
            // 
            // txtschID
            // 
            txtschID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtschID.Location = new Point(58, 211);
            txtschID.Name = "txtschID";
            txtschID.Size = new Size(367, 33);
            txtschID.TabIndex = 0;
            txtschID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CIT_U_GLE_Building_01_original;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1699, 746);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 746);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signin";
            Text = "signin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtpass;
        private TextBox txtschID;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
    }
}