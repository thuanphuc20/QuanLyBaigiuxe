
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLKhachHang
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
            pnlQuanLyKH = new System.Windows.Forms.Panel();
            dateTimePickerHetHan = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            txtSDT = new System.Windows.Forms.TextBox();
            dateTimePickerKH = new System.Windows.Forms.DateTimePicker();
            cbVeThang = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            radNu = new System.Windows.Forms.RadioButton();
            radNam = new System.Windows.Forms.RadioButton();
            label6 = new System.Windows.Forms.Label();
            txtUuDai = new System.Windows.Forms.Label();
            txtGioToiDa = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtGioToiThieu = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtDiaChi = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtMaXe = new System.Windows.Forms.TextBox();
            txtCMND = new System.Windows.Forms.TextBox();
            txtTenKH = new System.Windows.Forms.TextBox();
            txtMaKH = new System.Windows.Forms.TextBox();
            dgvQLKhachHang = new System.Windows.Forms.DataGridView();
            btnReload = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnDangKy = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            pnlQuanLyKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(279, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(392, 45);
            label1.TabIndex = 41;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // pnlQuanLyKH
            // 
            pnlQuanLyKH.Controls.Add(dateTimePickerHetHan);
            pnlQuanLyKH.Controls.Add(label10);
            pnlQuanLyKH.Controls.Add(txtSDT);
            pnlQuanLyKH.Controls.Add(dateTimePickerKH);
            pnlQuanLyKH.Controls.Add(cbVeThang);
            pnlQuanLyKH.Controls.Add(label7);
            pnlQuanLyKH.Controls.Add(radNu);
            pnlQuanLyKH.Controls.Add(radNam);
            pnlQuanLyKH.Controls.Add(label6);
            pnlQuanLyKH.Controls.Add(txtUuDai);
            pnlQuanLyKH.Controls.Add(txtGioToiDa);
            pnlQuanLyKH.Controls.Add(label5);
            pnlQuanLyKH.Controls.Add(txtGioToiThieu);
            pnlQuanLyKH.Controls.Add(label4);
            pnlQuanLyKH.Controls.Add(txtDiaChi);
            pnlQuanLyKH.Controls.Add(label3);
            pnlQuanLyKH.Controls.Add(label2);
            pnlQuanLyKH.Controls.Add(txtMaXe);
            pnlQuanLyKH.Controls.Add(txtCMND);
            pnlQuanLyKH.Controls.Add(txtTenKH);
            pnlQuanLyKH.Controls.Add(txtMaKH);
            pnlQuanLyKH.Location = new System.Drawing.Point(2, 57);
            pnlQuanLyKH.Name = "pnlQuanLyKH";
            pnlQuanLyKH.Size = new System.Drawing.Size(944, 232);
            pnlQuanLyKH.TabIndex = 49;
            pnlQuanLyKH.ControlRemoved += pnlQuanLyKH_ControlRemoved;
            // 
            // dateTimePickerHetHan
            // 
            dateTimePickerHetHan.CustomFormat = "dd/MM/yyyy";
            dateTimePickerHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerHetHan.Location = new System.Drawing.Point(678, 190);
            dateTimePickerHetHan.Margin = new System.Windows.Forms.Padding(2);
            dateTimePickerHetHan.Name = "dateTimePickerHetHan";
            dateTimePickerHetHan.Size = new System.Drawing.Size(252, 27);
            dateTimePickerHetHan.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(497, 64);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(143, 28);
            label10.TabIndex = 25;
            label10.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(678, 64);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(252, 27);
            txtSDT.TabIndex = 8;
            txtSDT.Validating += txtSDT_Validating;
            // 
            // dateTimePickerKH
            // 
            dateTimePickerKH.CustomFormat = "dd/MM/yyyy";
            dateTimePickerKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerKH.Location = new System.Drawing.Point(170, 118);
            dateTimePickerKH.Margin = new System.Windows.Forms.Padding(2);
            dateTimePickerKH.Name = "dateTimePickerKH";
            dateTimePickerKH.Size = new System.Drawing.Size(252, 27);
            dateTimePickerKH.TabIndex = 3;
            dateTimePickerKH.Validating += dateTimePickerKH_Validating;
            // 
            // cbVeThang
            // 
            cbVeThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbVeThang.FormattingEnabled = true;
            cbVeThang.Location = new System.Drawing.Point(679, 152);
            cbVeThang.Margin = new System.Windows.Forms.Padding(2);
            cbVeThang.Name = "cbVeThang";
            cbVeThang.Size = new System.Drawing.Size(251, 28);
            cbVeThang.TabIndex = 10;
            cbVeThang.SelectedIndexChanged += cbVeThang_SelectedIndexChanged;
            cbVeThang.Validating += cbVeThang_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(498, 152);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(145, 28);
            label7.TabIndex = 26;
            label7.Text = "Loại vé tháng:";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new System.Drawing.Point(371, 161);
            radNu.Name = "radNu";
            radNu.Size = new System.Drawing.Size(50, 24);
            radNu.TabIndex = 5;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new System.Drawing.Point(170, 161);
            radNam.Name = "radNam";
            radNam.Size = new System.Drawing.Size(62, 24);
            radNam.TabIndex = 4;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(3, 159);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 28);
            label6.TabIndex = 26;
            label6.Text = "Giới tính:";
            // 
            // txtUuDai
            // 
            txtUuDai.AutoSize = true;
            txtUuDai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtUuDai.ForeColor = System.Drawing.Color.Black;
            txtUuDai.Location = new System.Drawing.Point(3, 110);
            txtUuDai.Name = "txtUuDai";
            txtUuDai.Size = new System.Drawing.Size(112, 28);
            txtUuDai.TabIndex = 26;
            txtUuDai.Text = "Ngày sinh:";
            // 
            // txtGioToiDa
            // 
            txtGioToiDa.AutoSize = true;
            txtGioToiDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtGioToiDa.ForeColor = System.Drawing.Color.Black;
            txtGioToiDa.Location = new System.Drawing.Point(498, 190);
            txtGioToiDa.Name = "txtGioToiDa";
            txtGioToiDa.Size = new System.Drawing.Size(145, 28);
            txtGioToiDa.TabIndex = 26;
            txtGioToiDa.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(498, 109);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 28);
            label5.TabIndex = 26;
            label5.Text = "Mã xe:";
            // 
            // txtGioToiThieu
            // 
            txtGioToiThieu.AutoSize = true;
            txtGioToiThieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtGioToiThieu.ForeColor = System.Drawing.Color.Black;
            txtGioToiThieu.Location = new System.Drawing.Point(498, 21);
            txtGioToiThieu.Name = "txtGioToiThieu";
            txtGioToiThieu.Size = new System.Drawing.Size(83, 28);
            txtGioToiThieu.TabIndex = 25;
            txtGioToiThieu.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(3, 199);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 28);
            label4.TabIndex = 25;
            label4.Text = "CMND:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(678, 21);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(251, 32);
            txtDiaChi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(1, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(165, 28);
            label3.TabIndex = 26;
            label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(1, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 28);
            label2.TabIndex = 25;
            label2.Text = "Mã khách hàng:";
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new System.Drawing.Point(679, 109);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.PlaceholderText = "Nhấp để đăng ký xe";
            txtMaXe.Size = new System.Drawing.Size(251, 27);
            txtMaXe.TabIndex = 9;
            txtMaXe.Click += txtMaXe_Click;
            txtMaXe.TextChanged += txtMaXe_TextChanged;
            // 
            // txtCMND
            // 
            txtCMND.Location = new System.Drawing.Point(169, 200);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new System.Drawing.Size(252, 27);
            txtCMND.TabIndex = 6;
            txtCMND.Validating += txtCMND_Validating;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(170, 68);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(251, 27);
            txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new System.Drawing.Point(169, 21);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new System.Drawing.Size(252, 27);
            txtMaKH.TabIndex = 1;
            txtMaKH.Validating += txtMaKH_Validating;
            // 
            // dgvQLKhachHang
            // 
            dgvQLKhachHang.BackgroundColor = System.Drawing.Color.White;
            dgvQLKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvQLKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKhachHang.Location = new System.Drawing.Point(12, 414);
            dgvQLKhachHang.Name = "dgvQLKhachHang";
            dgvQLKhachHang.RowHeadersWidth = 51;
            dgvQLKhachHang.Size = new System.Drawing.Size(923, 289);
            dgvQLKhachHang.TabIndex = 50;
            dgvQLKhachHang.CellClick += dgvQLKhachHang_CellClick;
            // 
            // btnReload
            // 
            btnReload.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReload.ForeColor = System.Drawing.Color.White;
            btnReload.Location = new System.Drawing.Point(211, 367);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(94, 41);
            btnReload.TabIndex = 20;
            btnReload.Text = "Làm mới";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(798, 295);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(94, 41);
            btnHuy.TabIndex = 19;
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
            btnLuu.Location = new System.Drawing.Point(12, 367);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(93, 41);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(211, 295);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(94, 41);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDangKy.ForeColor = System.Drawing.Color.White;
            btnDangKy.Location = new System.Drawing.Point(12, 295);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new System.Drawing.Size(94, 41);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 0;
            // 
            // QLKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(947, 715);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnReload);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnDangKy);
            Controls.Add(dgvQLKhachHang);
            Controls.Add(pnlQuanLyKH);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "QLKhachHang";
            Text = "QLKhachHang";
            Load += QLKhachHang_Load;
            pnlQuanLyKH.ResumeLayout(false);
            pnlQuanLyKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuanLyKH;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtUuDai;
        private System.Windows.Forms.Label txtGioToiDa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtGioToiThieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvQLKhachHang;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbVeThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dateTimePickerHetHan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}