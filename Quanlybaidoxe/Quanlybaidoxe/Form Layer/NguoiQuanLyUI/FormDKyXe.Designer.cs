namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class FormDKyXe
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtBienSo = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtMauSac = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtTenXe = new System.Windows.Forms.TextBox();
            txtMaXe = new System.Windows.Forms.TextBox();
            pnlDKyXe = new System.Windows.Forms.Panel();
            cbLoaiXe = new System.Windows.Forms.ComboBox();
            btnLuu = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            pnlDKyXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(545, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 28);
            label1.TabIndex = 26;
            label1.Text = "Loại xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(4, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 28);
            label2.TabIndex = 26;
            label2.Text = "Biển số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(557, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 28);
            label3.TabIndex = 26;
            label3.Text = "Màu xe:";
            // 
            // txtBienSo
            // 
            txtBienSo.Location = new System.Drawing.Point(170, 123);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new System.Drawing.Size(251, 27);
            txtBienSo.TabIndex = 7;
            txtBienSo.Validating += txtBienSo_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(2, 77);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 28);
            label5.TabIndex = 26;
            label5.Text = "Tên xe:";
            // 
            // txtMauSac
            // 
            txtMauSac.Location = new System.Drawing.Point(670, 95);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new System.Drawing.Size(251, 27);
            txtMauSac.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(2, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 28);
            label6.TabIndex = 25;
            label6.Text = "Mã xe:";
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new System.Drawing.Point(170, 81);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new System.Drawing.Size(251, 27);
            txtTenXe.TabIndex = 7;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new System.Drawing.Point(170, 34);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new System.Drawing.Size(252, 27);
            txtMaXe.TabIndex = 5;
            txtMaXe.Validating += txtMaXe_Validating;
            // 
            // pnlDKyXe
            // 
            pnlDKyXe.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            pnlDKyXe.Controls.Add(cbLoaiXe);
            pnlDKyXe.Controls.Add(btnLuu);
            pnlDKyXe.Controls.Add(txtMaXe);
            pnlDKyXe.Controls.Add(txtTenXe);
            pnlDKyXe.Controls.Add(label6);
            pnlDKyXe.Controls.Add(txtMauSac);
            pnlDKyXe.Controls.Add(label5);
            pnlDKyXe.Controls.Add(txtBienSo);
            pnlDKyXe.Controls.Add(label3);
            pnlDKyXe.Controls.Add(label2);
            pnlDKyXe.Controls.Add(label1);
            pnlDKyXe.Location = new System.Drawing.Point(2, 2);
            pnlDKyXe.Margin = new System.Windows.Forms.Padding(2);
            pnlDKyXe.Name = "pnlDKyXe";
            pnlDKyXe.Size = new System.Drawing.Size(944, 232);
            pnlDKyXe.TabIndex = 29;
            // 
            // cbLoaiXe
            // 
            cbLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbLoaiXe.FormattingEnabled = true;
            cbLoaiXe.Location = new System.Drawing.Point(669, 34);
            cbLoaiXe.Name = "cbLoaiXe";
            cbLoaiXe.Size = new System.Drawing.Size(252, 28);
            cbLoaiXe.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
            btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLuu.Location = new System.Drawing.Point(670, 176);
            btnLuu.Margin = new System.Windows.Forms.Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(84, 26);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDKyXe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1013, 466);
            Controls.Add(pnlDKyXe);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormDKyXe";
            Text = "FormDKyXe";
            Load += FormDKyXe_Load;
            pnlDKyXe.ResumeLayout(false);
            pnlDKyXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Panel pnlDKyXe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}