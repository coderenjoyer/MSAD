namespace MSAD
{
    partial class pnlUsers
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
            dgvusers = new DataGridView();
            lbl2 = new Label();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvusers).BeginInit();
            SuspendLayout();
            // 
            // dgvusers
            // 
            dgvusers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvusers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusers.Location = new Point(59, 88);
            dgvusers.Margin = new Padding(3, 2, 3, 2);
            dgvusers.Name = "dgvusers";
            dgvusers.RowHeadersWidth = 51;
            dgvusers.Size = new Size(767, 677);
            dgvusers.TabIndex = 19;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(59, 34);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(90, 39);
            lbl2.TabIndex = 20;
            lbl2.Text = "Users";
            // 
            // btndelete
            // 
            btndelete.Location = new Point(701, 786);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(125, 32);
            btndelete.TabIndex = 21;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // pnlUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndelete);
            Controls.Add(lbl2);
            Controls.Add(dgvusers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnlUsers";
            Size = new Size(1904, 846);
            Load += pnlUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvusers;
        private Label lbl2;
        private Button btndelete;
    }
}
