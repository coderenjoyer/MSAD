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
            dgvdocureq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdocureq.Location = new Point(18, 72);
            dgvdocureq.Name = "dgvdocureq";
            dgvdocureq.Size = new Size(1584, 575);
            dgvdocureq.TabIndex = 4;
            // 
            // pnlVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvdocureq);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnlVerification";
            Size = new Size(1904, 846);
            Load += pnlVerification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdocureq).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private DataGridView dgvdocureq;
    }
}
