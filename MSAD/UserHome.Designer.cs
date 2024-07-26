namespace MSAD
{
    partial class UserHome
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
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnlogout = new Button();
            btnreqdoc = new Button();
            btnhome = new Button();
            mainpanel = new Panel();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 106);
            label3.Name = "label3";
            label3.Size = new Size(243, 24);
            label3.TabIndex = 5;
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
            label2.TabIndex = 4;
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnlogout);
            panel2.Controls.Add(btnreqdoc);
            panel2.Controls.Add(btnhome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 45);
            panel2.TabIndex = 1;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Maroon;
            btnlogout.Dock = DockStyle.Right;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(1659, 0);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(243, 43);
            btnlogout.TabIndex = 3;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnreqdoc
            // 
            btnreqdoc.BackColor = Color.Maroon;
            btnreqdoc.Dock = DockStyle.Left;
            btnreqdoc.FlatStyle = FlatStyle.Flat;
            btnreqdoc.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreqdoc.ForeColor = Color.White;
            btnreqdoc.Location = new Point(244, 0);
            btnreqdoc.Name = "btnreqdoc";
            btnreqdoc.Size = new Size(232, 43);
            btnreqdoc.TabIndex = 3;
            btnreqdoc.Text = "Document Status";
            btnreqdoc.UseVisualStyleBackColor = false;
            btnreqdoc.Click += btnreqdoc_Click;
            // 
            // btnhome
            // 
            btnhome.BackColor = Color.Maroon;
            btnhome.Dock = DockStyle.Left;
            btnhome.FlatStyle = FlatStyle.Flat;
            btnhome.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnhome.ForeColor = Color.White;
            btnhome.Location = new Point(0, 0);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(244, 43);
            btnhome.TabIndex = 2;
            btnhome.Text = "Home";
            btnhome.UseVisualStyleBackColor = false;
            btnhome.Click += btnhome_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 195);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1904, 846);
            mainpanel.TabIndex = 2;
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserHome";
            Text = "UserHome";
            Load += UserHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Button btnlogout;
        private Button btnreqdoc;
        private Button btnhome;
        private Panel mainpanel;
    }
}