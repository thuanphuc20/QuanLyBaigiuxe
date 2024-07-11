
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class ThongKeDoanhThu
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
            dgvTongThu = new System.Windows.Forms.DataGridView();
            dgvDoanhThu = new System.Windows.Forms.DataGridView();
            btnThongKe = new System.Windows.Forms.Button();
            dtgiora = new System.Windows.Forms.DateTimePicker();
            dtgiovao = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvTongThu
            // 
            dgvTongThu.BackgroundColor = System.Drawing.Color.White;
            dgvTongThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTongThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongThu.Location = new System.Drawing.Point(730, 214);
            dgvTongThu.Name = "dgvTongThu";
            dgvTongThu.RowHeadersWidth = 51;
            dgvTongThu.Size = new System.Drawing.Size(205, 490);
            dgvTongThu.TabIndex = 61;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new System.Drawing.Point(12, 214);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.Size = new System.Drawing.Size(712, 490);
            dgvDoanhThu.TabIndex = 60;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
            btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThongKe.ForeColor = System.Drawing.Color.White;
            btnThongKe.Location = new System.Drawing.Point(426, 100);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new System.Drawing.Size(94, 41);
            btnThongKe.TabIndex = 59;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtgiora
            // 
            dtgiora.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            dtgiora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtgiora.Location = new System.Drawing.Point(648, 114);
            dtgiora.Name = "dtgiora";
            dtgiora.Size = new System.Drawing.Size(201, 27);
            dtgiora.TabIndex = 57;
            dtgiora.Validating += dtgiora_Validating;
            // 
            // dtgiovao
            // 
            dtgiovao.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            dtgiovao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtgiovao.Location = new System.Drawing.Point(97, 114);
            dtgiovao.Name = "dtgiovao";
            dtgiovao.Size = new System.Drawing.Size(203, 27);
            dtgiovao.TabIndex = 58;
            dtgiovao.Value = new System.DateTime(2021, 5, 14, 0, 26, 31, 0);
            dtgiovao.Validating += dtgiovao_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(350, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(220, 45);
            label1.TabIndex = 56;
            label1.Text = "DOANH THU";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(255, 98, 0);
            label2.Location = new System.Drawing.Point(97, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 35);
            label2.TabIndex = 62;
            label2.Text = "Giờ ra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(255, 98, 0);
            label3.Location = new System.Drawing.Point(648, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 35);
            label3.TabIndex = 63;
            label3.Text = "Giờ vào";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(97, 165);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(380, 28);
            label4.TabIndex = 64;
            label4.Text = "Hóa đơn khách hàng đăng ký vé tháng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(730, 165);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(209, 28);
            label5.TabIndex = 65;
            label5.Text = "Thu ngày + vé tháng";
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            ClientSize = new System.Drawing.Size(947, 715);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTongThu);
            Controls.Add(dgvDoanhThu);
            Controls.Add(btnThongKe);
            Controls.Add(dtgiora);
            Controls.Add(dtgiovao);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ThongKeDoanhThu";
            Text = "ThongKeDoanhThu";
            Load += ThongKeDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTongThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtgiora;
        private System.Windows.Forms.DateTimePicker dtgiovao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}