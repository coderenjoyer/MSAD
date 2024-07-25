namespace MSAD
{
    partial class Flogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnexit = new Button();
            btnsignin = new Button();
            btnregis = new Button();
            mainpanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 150);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnsignin);
            panel2.Controls.Add(btnregis);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 45);
            panel2.TabIndex = 1;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Maroon;
            btnexit.Dock = DockStyle.Right;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(1658, 0);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(244, 43);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.Maroon;
            btnsignin.Dock = DockStyle.Left;
            btnsignin.FlatStyle = FlatStyle.Flat;
            btnsignin.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = Color.White;
            btnsignin.Location = new Point(244, 0);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(244, 43);
            btnsignin.TabIndex = 6;
            btnsignin.Text = "Sign In";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // btnregis
            // 
            btnregis.BackColor = Color.Maroon;
            btnregis.Dock = DockStyle.Left;
            btnregis.FlatStyle = FlatStyle.Flat;
            btnregis.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregis.ForeColor = Color.White;
            btnregis.Location = new Point(0, 0);
            btnregis.Name = "btnregis";
            btnregis.Size = new Size(244, 43);
            btnregis.TabIndex = 5;
            btnregis.Text = "Register";
            btnregis.UseVisualStyleBackColor = false;
            btnregis.Click += btnregis_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 195);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1904, 846);
            mainpanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 106);
            label3.Name = "label3";
            label3.Size = new Size(243, 24);
            label3.TabIndex = 7;
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
            label2.TabIndex = 6;
            label2.Text = "TekDok";
            // 
            // Flogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Flogin";
            Text = "Flogin";
            Load += Flogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainpanel;
        private PictureBox pictureBox1;
        private Button btnregis;
        private Button btnsignin;
        private Button btnexit;
        private Label label3;
        private Label label2;
    }
}