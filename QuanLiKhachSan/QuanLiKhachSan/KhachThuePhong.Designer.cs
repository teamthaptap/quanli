namespace QuanLiKhachSan
{
    partial class KhachThuePhong
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 183);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaKH,
            this.cmlTenKH,
            this.clmGT,
            this.clmNgaySinh,
            this.clmCMND});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmMaKH
            // 
            this.clmMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmMaKH.DataPropertyName = "MaKH";
            this.clmMaKH.HeaderText = "Mã KH";
            this.clmMaKH.Name = "clmMaKH";
            this.clmMaKH.ReadOnly = true;
            this.clmMaKH.Width = 137;
            // 
            // cmlTenKH
            // 
            this.cmlTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmlTenKH.DataPropertyName = "TenKH";
            this.cmlTenKH.HeaderText = "Tên KH";
            this.cmlTenKH.Name = "cmlTenKH";
            this.cmlTenKH.ReadOnly = true;
            // 
            // clmGT
            // 
            this.clmGT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmGT.DataPropertyName = "GT";
            this.clmGT.HeaderText = "Giới Tính";
            this.clmGT.Name = "clmGT";
            this.clmGT.ReadOnly = true;
            this.clmGT.Width = 137;
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmNgaySinh.DataPropertyName = "NgaySinh";
            this.clmNgaySinh.HeaderText = "Ngày Sinh";
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.ReadOnly = true;
            // 
            // clmCMND
            // 
            this.clmCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCMND.DataPropertyName = "CMND";
            this.clmCMND.HeaderText = "CMND";
            this.clmCMND.Name = "clmCMND";
            this.clmCMND.ReadOnly = true;
            this.clmCMND.Width = 137;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGT);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbGT
            // 
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGT.Location = new System.Drawing.Point(69, 77);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(121, 21);
            this.cmbGT.TabIndex = 13;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(336, 13);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaySinh.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Sinh";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(336, 44);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 20);
            this.txtCMND.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CMTND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(64, 44);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(161, 20);
            this.txtTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KH";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(64, 13);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(161, 20);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttThoat);
            this.groupBox2.Controls.Add(this.bttXoa);
            this.groupBox2.Controls.Add(this.bttLuu);
            this.groupBox2.Controls.Add(this.bttSua);
            this.groupBox2.Controls.Add(this.bttThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(512, 11);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 23);
            this.bttThoat.TabIndex = 4;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(290, 11);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(75, 23);
            this.bttXoa.TabIndex = 3;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(393, 11);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(75, 23);
            this.bttLuu.TabIndex = 2;
            this.bttLuu.Text = "Cập nhật";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Location = new System.Drawing.Point(176, 11);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(75, 23);
            this.bttSua.TabIndex = 1;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttThem
            // 
            this.bttThem.Location = new System.Drawing.Point(53, 11);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(75, 23);
            this.bttThem.TabIndex = 0;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // KhachThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhachThuePhong";
            this.Text = "KhachThuePhong";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttThem;
    }
}