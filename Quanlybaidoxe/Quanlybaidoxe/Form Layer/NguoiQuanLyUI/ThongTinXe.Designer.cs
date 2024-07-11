namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class ThongTinXe
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
            dgvXeDK = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            dgvXeChuaDK = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvXeDK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvXeChuaDK).BeginInit();
            SuspendLayout();
            // 
            // dgvXeDK
            // 
            dgvXeDK.BackgroundColor = System.Drawing.Color.White;
            dgvXeDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeDK.Location = new System.Drawing.Point(174, 118);
            dgvXeDK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvXeDK.Name = "dgvXeDK";
            dgvXeDK.RowHeadersWidth = 57;
            dgvXeDK.Size = new System.Drawing.Size(572, 205);
            dgvXeDK.TabIndex = 0;
            dgvXeDK.Text = "dataGridView1";
            dgvXeDK.CellClick += dgvXeDK_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(359, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 45);
            label1.TabIndex = 41;
            label1.Text = "THÔNG TIN XE";
            // 
            // dgvXeChuaDK
            // 
            dgvXeChuaDK.BackgroundColor = System.Drawing.Color.White;
            dgvXeChuaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeChuaDK.Location = new System.Drawing.Point(174, 420);
            dgvXeChuaDK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvXeChuaDK.Name = "dgvXeChuaDK";
            dgvXeChuaDK.RowHeadersWidth = 57;
            dgvXeChuaDK.Size = new System.Drawing.Size(572, 205);
            dgvXeChuaDK.TabIndex = 0;
            dgvXeChuaDK.Text = "dataGridView2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(10, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(247, 37);
            label2.TabIndex = 41;
            label2.Text = "Xe đã đăng ký thẻ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(10, 350);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(277, 37);
            label3.TabIndex = 41;
            label3.Text = "Xe chưa đăng ký thẻ";
            // 
            // ThongTinXe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(949, 720);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvXeChuaDK);
            Controls.Add(label1);
            Controls.Add(dgvXeDK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "ThongTinXe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thông tin xe";
            Load += ThongTinXe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvXeDK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvXeChuaDK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXeDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvXeChuaDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}