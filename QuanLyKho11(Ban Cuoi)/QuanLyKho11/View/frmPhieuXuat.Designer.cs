namespace QuanLyKho11.View
{
    partial class frmPhieuXuat
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbMaKho = new System.Windows.Forms.ComboBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSLThuc = new System.Windows.Forms.TextBox();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHuy.Location = new System.Drawing.Point(400, 149);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 32);
            this.btnHuy.TabIndex = 65;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.Location = new System.Drawing.Point(304, 149);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(59, 32);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(199, 149);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 32);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(105, 149);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 32);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(9, 149);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 32);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMaKho
            // 
            this.cbbMaKho.FormattingEnabled = true;
            this.cbbMaKho.Location = new System.Drawing.Point(341, 70);
            this.cbbMaKho.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKho.Name = "cbbMaKho";
            this.cbbMaKho.Size = new System.Drawing.Size(103, 21);
            this.cbbMaKho.TabIndex = 44;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(341, 31);
            this.cbbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(103, 21);
            this.cbbMaKH.TabIndex = 43;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(83, 70);
            this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(128, 20);
            this.dtpNgayXuat.TabIndex = 42;
            // 
            // txtMaPX
            // 
            this.txtMaPX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPX.Enabled = false;
            this.txtMaPX.Location = new System.Drawing.Point(83, 32);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(128, 20);
            this.txtMaPX.TabIndex = 41;
            this.txtMaPX.TextChanged += new System.EventHandler(this.txtMaPX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "MaKho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày Xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Phiếu Xuất";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.cbbMaKho);
            this.groupBox4.Controls.Add(this.cbbMaKH);
            this.groupBox4.Controls.Add(this.dtpNgayXuat);
            this.groupBox4.Controls.Add(this.txtMaPX);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(502, 212);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(83, 109);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(128, 20);
            this.txtTongTien.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(6, 16);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowTemplate.Height = 28;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(492, 215);
            this.dgvPhieuXuat.TabIndex = 0;
            this.dgvPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellClick);
            this.dgvPhieuXuat.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPhieuXuat_RowPrePaint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhieuXuat);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(5, 222);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(502, 235);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(525, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(509, 224);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuuCT.Location = new System.Drawing.Point(330, 155);
            this.btnLuuCT.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(77, 32);
            this.btnLuuCT.TabIndex = 60;
            this.btnLuuCT.Text = "Lưu";
            this.btnLuuCT.UseVisualStyleBackColor = false;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaCT.Location = new System.Drawing.Point(228, 155);
            this.btnXoaCT.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(77, 32);
            this.btnXoaCT.TabIndex = 58;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTroLai.Location = new System.Drawing.Point(436, 155);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(77, 32);
            this.btnTroLai.TabIndex = 50;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaCT.Location = new System.Drawing.Point(123, 155);
            this.btnSuaCT.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(77, 32);
            this.btnSuaCT.TabIndex = 48;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemHang.Location = new System.Drawing.Point(19, 155);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(79, 32);
            this.btnThemHang.TabIndex = 47;
            this.btnThemHang.Text = "Thêm hàng";
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Số Lượng thực";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Mã hàng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(99, 124);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(187, 20);
            this.txtThanhTien.TabIndex = 42;
            this.txtThanhTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThanhTien_MouseClick);
            // 
            // txtSLThuc
            // 
            this.txtSLThuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSLThuc.Enabled = false;
            this.txtSLThuc.Location = new System.Drawing.Point(99, 96);
            this.txtSLThuc.Name = "txtSLThuc";
            this.txtSLThuc.Size = new System.Drawing.Size(187, 20);
            this.txtSLThuc.TabIndex = 41;
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(99, 27);
            this.cbbMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(82, 21);
            this.cbbMaHang.TabIndex = 40;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(99, 59);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(187, 20);
            this.txtDonGia.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSLThuc);
            this.groupBox1.Controls.Add(this.btnXoaCT);
            this.groupBox1.Controls.Add(this.btnLuuCT);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.btnTroLai);
            this.groupBox1.Controls.Add(this.cbbMaHang);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSuaCT);
            this.groupBox1.Controls.Add(this.btnThemHang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(511, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(527, 212);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKho11.Properties.Resources.nhu_cau_nha_xuong_cong_nghiep_hien_nay;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(336, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 116);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvChiTiet);
            this.groupBox5.Location = new System.Drawing.Point(517, 222);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(522, 235);
            this.groupBox5.TabIndex = 62;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách hàng";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(4, 16);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowTemplate.Height = 28;
            this.dgvChiTiet.Size = new System.Drawing.Size(514, 214);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 467);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbMaKho;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSLThuc;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}