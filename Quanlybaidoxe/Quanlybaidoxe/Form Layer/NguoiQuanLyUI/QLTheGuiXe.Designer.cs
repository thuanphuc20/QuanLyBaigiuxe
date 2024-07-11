namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLTheGuiXe
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
            components = new System.ComponentModel.Container();
            label2 = new System.Windows.Forms.Label();
            txtMaThe = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnLamMoi = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            dgvTheGuiXe = new System.Windows.Forms.DataGridView();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheGuiXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(277, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 28);
            label2.TabIndex = 25;
            label2.Text = "Mã thẻ:";
            // 
            // txtMaThe
            // 
            txtMaThe.Location = new System.Drawing.Point(416, 59);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.Size = new System.Drawing.Size(252, 27);
            txtMaThe.TabIndex = 1;
          
            txtMaThe.Validating += txtMaThe_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(295, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(350, 45);
            label3.TabIndex = 38;
            label3.Text = "QUẢN LÝ THẺ GỬI XE";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaThe);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(97, 66);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(855, 152);
            panel1.TabIndex = 39;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLamMoi.ForeColor = System.Drawing.Color.White;
            btnLamMoi.Location = new System.Drawing.Point(374, 252);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(94, 41);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(238, 324);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(94, 41);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Location = new System.Drawing.Point(97, 324);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(94, 41);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(238, 252);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(94, 41);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(97, 252);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(94, 41);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvTheGuiXe
            // 
            dgvTheGuiXe.BackgroundColor = System.Drawing.Color.White;
            dgvTheGuiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheGuiXe.Location = new System.Drawing.Point(530, 252);
            dgvTheGuiXe.Margin = new System.Windows.Forms.Padding(2);
            dgvTheGuiXe.Name = "dgvTheGuiXe";
            dgvTheGuiXe.RowHeadersWidth = 57;
            dgvTheGuiXe.Size = new System.Drawing.Size(422, 482);
            dgvTheGuiXe.TabIndex = 56;
            dgvTheGuiXe.Text = "dataGridView1";
            dgvTheGuiXe.CellClick += dgvTheGuiXe_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // QLTheGuiXe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(1029, 762);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(btnLamMoi);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dgvTheGuiXe);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "QLTheGuiXe";
            Text = "QLTheGuiXe";
            Load += QLTheGuiXe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheGuiXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTheGuiXe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}