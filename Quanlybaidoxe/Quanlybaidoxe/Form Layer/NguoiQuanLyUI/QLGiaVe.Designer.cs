
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLGiaVe
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
            label1 = new System.Windows.Forms.Label();
            dgvGiaVe = new System.Windows.Forms.DataGridView();
            pnlQuanLyGiaVe = new System.Windows.Forms.Panel();
            txtSoThang = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            checkBoxVeThang = new System.Windows.Forms.CheckBox();
            cboLoaiXe = new System.Windows.Forms.ComboBox();
            txt3 = new System.Windows.Forms.Label();
            txt1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txt2 = new System.Windows.Forms.Label();
            txtUuDai = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtGioToiDa = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtGioToiThieu = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtGiaVe = new System.Windows.Forms.TextBox();
            txtTenGiaVe = new System.Windows.Forms.TextBox();
            txtMaGiaVe = new System.Windows.Forms.TextBox();
            btnReload = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvGiaVe).BeginInit();
            pnlQuanLyGiaVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(340, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 45);
            label1.TabIndex = 39;
            label1.Text = "QUẢN LÝ GIÁ VÉ";
            // 
            // dgvGiaVe
            // 
            dgvGiaVe.BackgroundColor = System.Drawing.Color.White;
            dgvGiaVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaVe.Location = new System.Drawing.Point(12, 432);
            dgvGiaVe.Name = "dgvGiaVe";
            dgvGiaVe.RowHeadersWidth = 51;
            dgvGiaVe.Size = new System.Drawing.Size(923, 318);
            dgvGiaVe.TabIndex = 46;
            dgvGiaVe.CellClick += dgvGiaVe_CellClick;
            // 
            // pnlQuanLyGiaVe
            // 
            pnlQuanLyGiaVe.Controls.Add(txtSoThang);
            pnlQuanLyGiaVe.Controls.Add(label6);
            pnlQuanLyGiaVe.Controls.Add(checkBoxVeThang);
            pnlQuanLyGiaVe.Controls.Add(cboLoaiXe);
            pnlQuanLyGiaVe.Controls.Add(txt3);
            pnlQuanLyGiaVe.Controls.Add(txt1);
            pnlQuanLyGiaVe.Controls.Add(label5);
            pnlQuanLyGiaVe.Controls.Add(txt2);
            pnlQuanLyGiaVe.Controls.Add(txtUuDai);
            pnlQuanLyGiaVe.Controls.Add(label4);
            pnlQuanLyGiaVe.Controls.Add(txtGioToiDa);
            pnlQuanLyGiaVe.Controls.Add(label3);
            pnlQuanLyGiaVe.Controls.Add(txtGioToiThieu);
            pnlQuanLyGiaVe.Controls.Add(label2);
            pnlQuanLyGiaVe.Controls.Add(txtGiaVe);
            pnlQuanLyGiaVe.Controls.Add(txtTenGiaVe);
            pnlQuanLyGiaVe.Controls.Add(txtMaGiaVe);
            pnlQuanLyGiaVe.Location = new System.Drawing.Point(12, 57);
            pnlQuanLyGiaVe.Name = "pnlQuanLyGiaVe";
            pnlQuanLyGiaVe.Size = new System.Drawing.Size(944, 232);
            pnlQuanLyGiaVe.TabIndex = 47;
            // 
            // txtSoThang
            // 
            txtSoThang.Location = new System.Drawing.Point(669, 186);
            txtSoThang.Name = "txtSoThang";
            txtSoThang.Size = new System.Drawing.Size(251, 27);
            txtSoThang.TabIndex = 7;
            txtSoThang.Validating += txtSoThang_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(510, 194);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 28);
            label6.TabIndex = 26;
            label6.Text = "Số tháng:";
            // 
            // checkBoxVeThang
            // 
            checkBoxVeThang.AutoSize = true;
            checkBoxVeThang.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            checkBoxVeThang.ForeColor = System.Drawing.Color.Black;
            checkBoxVeThang.Location = new System.Drawing.Point(498, 153);
            checkBoxVeThang.Name = "checkBoxVeThang";
            checkBoxVeThang.Size = new System.Drawing.Size(119, 32);
            checkBoxVeThang.TabIndex = 8;
            checkBoxVeThang.Text = "Vé tháng";
            checkBoxVeThang.UseVisualStyleBackColor = true;
            checkBoxVeThang.CheckedChanged += checkBoxVeThang_CheckedChanged;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Location = new System.Drawing.Point(161, 154);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new System.Drawing.Size(252, 28);
            cboLoaiXe.TabIndex = 4;
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt3.ForeColor = System.Drawing.Color.Black;
            txt3.Location = new System.Drawing.Point(498, 113);
            txt3.Name = "txt3";
            txt3.Size = new System.Drawing.Size(81, 28);
            txt3.TabIndex = 26;
            txt3.Text = "Ưu đãi:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt1.ForeColor = System.Drawing.Color.Black;
            txt1.Location = new System.Drawing.Point(498, 65);
            txt1.Name = "txt1";
            txt1.Size = new System.Drawing.Size(112, 28);
            txt1.TabIndex = 26;
            txt1.Text = "Giờ tối đa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(1, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 28);
            label5.TabIndex = 26;
            label5.Text = "Loại xe:";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt2.ForeColor = System.Drawing.Color.Black;
            txt2.Location = new System.Drawing.Point(498, 20);
            txt2.Name = "txt2";
            txt2.Size = new System.Drawing.Size(137, 28);
            txt2.TabIndex = 25;
            txt2.Text = "Giờ tối thiểu:";
            // 
            // txtUuDai
            // 
            txtUuDai.Location = new System.Drawing.Point(669, 113);
            txtUuDai.Name = "txtUuDai";
            txtUuDai.Size = new System.Drawing.Size(251, 27);
            txtUuDai.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(1, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 28);
            label4.TabIndex = 25;
            label4.Text = "Giá vé:";
            // 
            // txtGioToiDa
            // 
            txtGioToiDa.Location = new System.Drawing.Point(669, 68);
            txtGioToiDa.Name = "txtGioToiDa";
            txtGioToiDa.Size = new System.Drawing.Size(251, 27);
            txtGioToiDa.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(1, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 28);
            label3.TabIndex = 26;
            label3.Text = "Tên giá vé:";
            // 
            // txtGioToiThieu
            // 
            txtGioToiThieu.Location = new System.Drawing.Point(668, 19);
            txtGioToiThieu.Name = "txtGioToiThieu";
            txtGioToiThieu.Size = new System.Drawing.Size(252, 27);
            txtGioToiThieu.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(1, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 28);
            label2.TabIndex = 25;
            label2.Text = "Mã giá vé:";
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new System.Drawing.Point(161, 110);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new System.Drawing.Size(252, 27);
            txtGiaVe.TabIndex = 3;
            // 
            // txtTenGiaVe
            // 
            txtTenGiaVe.Location = new System.Drawing.Point(161, 66);
            txtTenGiaVe.Name = "txtTenGiaVe";
            txtTenGiaVe.Size = new System.Drawing.Size(251, 27);
            txtTenGiaVe.TabIndex = 2;
            // 
            // txtMaGiaVe
            // 
            txtMaGiaVe.Location = new System.Drawing.Point(161, 20);
            txtMaGiaVe.Name = "txtMaGiaVe";
            txtMaGiaVe.Size = new System.Drawing.Size(252, 27);
            txtMaGiaVe.TabIndex = 1;
            // 
            // btnReload
            // 
            btnReload.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
            btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReload.ForeColor = System.Drawing.Color.White;
            btnReload.Location = new System.Drawing.Point(354, 367);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(94, 41);
            btnReload.TabIndex = 55;
            btnReload.Text = "Làm mới";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(186, 367);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(94, 41);
            btnHuy.TabIndex = 54;
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
            btnLuu.Location = new System.Drawing.Point(13, 367);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(94, 41);
            btnLuu.TabIndex = 53;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(354, 295);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(94, 41);
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(186, 295);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(94, 41);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(13, 295);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(94, 41);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // QLGiaVe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(965, 762);
            Controls.Add(btnReload);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(pnlQuanLyGiaVe);
            Controls.Add(dgvGiaVe);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "QLGiaVe";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaVe).EndInit();
            pnlQuanLyGiaVe.ResumeLayout(false);
            pnlQuanLyGiaVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiaVe;
        private System.Windows.Forms.Panel pnlQuanLyNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGiaVe;
        private System.Windows.Forms.TextBox txtMaGiaVe;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox txtUuDai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGioToiDa;
        private System.Windows.Forms.TextBox txtGioToiThieu;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.CheckBox checkBoxVeThang;
        private System.Windows.Forms.Panel pnlQuanLyGiaVe;
        private System.Windows.Forms.TextBox txtSoThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}