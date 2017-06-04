namespace QuanLyKho11.View
{
    partial class frmPhieuNhap
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.cbbMaKho = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.cbbMaNCC);
            this.groupBox4.Controls.Add(this.cbbMaKho);
            this.groupBox4.Controls.Add(this.dtpNgayNhap);
            this.groupBox4.Controls.Add(this.txtMaPN);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(996, 326);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu Nhập";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHuy.Location = new System.Drawing.Point(600, 229);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 65;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.Location = new System.Drawing.Point(456, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 50);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(298, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(157, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 50);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(13, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 50);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(511, 108);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(152, 28);
            this.cbbMaNCC.TabIndex = 44;
            // 
            // cbbMaKho
            // 
            this.cbbMaKho.FormattingEnabled = true;
            this.cbbMaKho.Location = new System.Drawing.Point(511, 47);
            this.cbbMaKho.Name = "cbbMaKho";
            this.cbbMaKho.Size = new System.Drawing.Size(152, 28);
            this.cbbMaKho.TabIndex = 43;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(125, 108);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(190, 26);
            this.dtpNgayNhap.TabIndex = 42;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(125, 50);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(190, 26);
            this.txtMaPN.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 361);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(9, 25);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowTemplate.Height = 28;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(713, 331);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(125, 164);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(190, 26);
            this.txtTongTien.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tổng tiền";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKho11.Properties.Resources.nhu_cau_nha_xuong_cong_nghiep_hien_nay;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(747, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 178);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXem.Location = new System.Drawing.Point(807, 389);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(140, 50);
            this.btnXem.TabIndex = 66;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrangChu.Location = new System.Drawing.Point(807, 524);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(140, 50);
            this.btnTrangChu.TabIndex = 67;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 718);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.ComboBox cbbMaKho;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTrangChu;
    }
}