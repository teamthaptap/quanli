namespace QuanLyKho11.View
{
    partial class frmChiTietPhieuNhap
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtThuKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSLThuc = new System.Windows.Forms.TextBox();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTiet);
            this.groupBox4.Location = new System.Drawing.Point(12, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1224, 344);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(15, 25);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowTemplate.Height = 28;
            this.dgvChiTiet.Size = new System.Drawing.Size(1209, 322);
            this.dgvChiTiet.TabIndex = 1;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.dtpNgayNhap);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtThuKho);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaPN);
            this.groupBox3.Controls.Add(this.btnTroLai);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThemHang);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.txtSLThuc);
            this.groupBox3.Controls.Add(this.cbbMaHang);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1224, 346);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.Location = new System.Drawing.Point(818, 261);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 50);
            this.btnLuu.TabIndex = 60;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHuy.Location = new System.Drawing.Point(649, 261);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 50);
            this.btnHuy.TabIndex = 59;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(492, 261);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 50);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(134, 92);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayNhap.TabIndex = 57;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(134, 146);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(192, 26);
            this.txtTongTien.TabIndex = 56;
            // 
            // txtThuKho
            // 
            this.txtThuKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThuKho.Enabled = false;
            this.txtThuKho.Location = new System.Drawing.Point(764, 170);
            this.txtThuKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThuKho.Name = "txtThuKho";
            this.txtThuKho.Size = new System.Drawing.Size(0, 26);
            this.txtThuKho.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã PN";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(134, 43);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(215, 26);
            this.txtMaPN.TabIndex = 51;
            this.txtMaPN.TextChanged += new System.EventHandler(this.txtMaPN_TextChanged);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTroLai.Location = new System.Drawing.Point(984, 261);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(115, 50);
            this.btnTroLai.TabIndex = 50;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKho11.Properties.Resources.nhu_cau_nha_xuong_cong_nghiep_hien_nay;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(984, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 178);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(314, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 50);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemHang.Location = new System.Drawing.Point(134, 261);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(119, 50);
            this.btnThemHang.TabIndex = 47;
            this.btnThemHang.Text = "Thêm hàng";
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Số Lượng thực";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mã hàng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(540, 195);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(278, 26);
            this.txtThanhTien.TabIndex = 42;
            // 
            // txtSLThuc
            // 
            this.txtSLThuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSLThuc.Enabled = false;
            this.txtSLThuc.Location = new System.Drawing.Point(540, 143);
            this.txtSLThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSLThuc.Name = "txtSLThuc";
            this.txtSLThuc.Size = new System.Drawing.Size(278, 26);
            this.txtSLThuc.TabIndex = 41;
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(540, 43);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(121, 28);
            this.cbbMaHang.TabIndex = 40;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(540, 97);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(278, 26);
            this.txtDonGia.TabIndex = 34;
            // 
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 718);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmChiTietPhieuNhap";
            this.Text = "frmChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.frmChiTietPhieuNhap_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSLThuc;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtThuKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
    }
}