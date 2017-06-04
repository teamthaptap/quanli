namespace WindowsFormsApplication1
{
    partial class HoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTGT = new System.Windows.Forms.DateTimePicker();
            this.dtTGM = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttCapNhat = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTGT);
            this.groupBox1.Controls.Add(this.dtTGM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dtTGT
            // 
            this.dtTGT.Location = new System.Drawing.Point(402, 68);
            this.dtTGT.Name = "dtTGT";
            this.dtTGT.Size = new System.Drawing.Size(200, 20);
            this.dtTGT.TabIndex = 11;
            // 
            // dtTGM
            // 
            this.dtTGM.Location = new System.Drawing.Point(92, 68);
            this.dtTGM.Name = "dtTGM";
            this.dtTGM.Size = new System.Drawing.Size(200, 20);
            this.dtTGM.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thời gian tra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thời gian mượn";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(402, 9);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(147, 20);
            this.txtNguoiLap.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Người lập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(403, 42);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(147, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(92, 42);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(147, 20);
            this.txtMaKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã KH";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(92, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(147, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttThoat);
            this.groupBox2.Controls.Add(this.bttXoa);
            this.groupBox2.Controls.Add(this.bttCapNhat);
            this.groupBox2.Controls.Add(this.bttSua);
            this.groupBox2.Controls.Add(this.bttThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 37);
            this.groupBox2.TabIndex = 9;
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
            // bttCapNhat
            // 
            this.bttCapNhat.Location = new System.Drawing.Point(393, 11);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(75, 23);
            this.bttCapNhat.TabIndex = 2;
            this.bttCapNhat.Text = "Cập nhật";
            this.bttCapNhat.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHoaDon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 204);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(624, 185);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã KH";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NguoiLap";
            this.Column3.HeaderText = "Người lập";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TGMuon";
            this.Column5.HeaderText = "Thời Gian mượn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TGTra";
            this.Column6.HeaderText = "Thời gian trả";
            this.Column6.Name = "Column6";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTGT;
        private System.Windows.Forms.DateTimePicker dtTGM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttCapNhat;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}