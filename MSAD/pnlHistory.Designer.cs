﻿namespace MSAD
{
    partial class pnlHistory
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
            label1 = new Label();
            dgvhistory = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvhistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(351, 75);
            label1.TabIndex = 4;
            label1.Text = "History Page";
            // 
            // dgvhistory
            // 
            dgvhistory.AllowUserToAddRows = false;
            dgvhistory.AllowUserToDeleteRows = false;
            dgvhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistory.Location = new Point(585, 36);
            dgvhistory.Name = "dgvhistory";
            dgvhistory.ReadOnly = true;
            dgvhistory.Size = new Size(734, 730);
            dgvhistory.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1172, 772);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            Controls.Add(button1);
            Controls.Add(dgvhistory);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnlHistory";
            Size = new Size(1904, 846);
            Load += pnlHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvhistory;
        private Button button1;
    }
}
