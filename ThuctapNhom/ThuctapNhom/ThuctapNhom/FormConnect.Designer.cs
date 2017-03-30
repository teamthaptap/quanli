namespace ThuctapNhom
{
    partial class FormConnect
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnknCSDL = new System.Windows.Forms.Button();
            this.btnldl = new System.Windows.Forms.Button();
            this.cbbListDB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbAuthen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(51, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(289, 34);
            this.lblMessage.TabIndex = 41;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnhuy
            // 
            this.btnhuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnhuy.Location = new System.Drawing.Point(268, 290);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(72, 23);
            this.btnhuy.TabIndex = 40;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnknCSDL
            // 
            this.btnknCSDL.Enabled = false;
            this.btnknCSDL.Location = new System.Drawing.Point(168, 290);
            this.btnknCSDL.Name = "btnknCSDL";
            this.btnknCSDL.Size = new System.Drawing.Size(93, 23);
            this.btnknCSDL.TabIndex = 39;
            this.btnknCSDL.Text = "Kết Nối CSDL";
            this.btnknCSDL.UseVisualStyleBackColor = true;
            this.btnknCSDL.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnldl
            // 
            this.btnldl.Location = new System.Drawing.Point(180, 188);
            this.btnldl.Name = "btnldl";
            this.btnldl.Size = new System.Drawing.Size(160, 23);
            this.btnldl.TabIndex = 36;
            this.btnldl.Text = "Lấy Danh Sách Database";
            this.btnldl.UseVisualStyleBackColor = true;
            this.btnldl.Click += new System.EventHandler(this.btnldl_Click);
            // 
            // cbbListDB
            // 
            this.cbbListDB.Enabled = false;
            this.cbbListDB.FormattingEnabled = true;
            this.cbbListDB.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbbListDB.Location = new System.Drawing.Point(141, 240);
            this.cbbListDB.Name = "cbbListDB";
            this.cbbListDB.Size = new System.Drawing.Size(199, 21);
            this.cbbListDB.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(48, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Chọn CSDL:";
            // 
            // cbbAuthen
            // 
            this.cbbAuthen.FormattingEnabled = true;
            this.cbbAuthen.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbbAuthen.Location = new System.Drawing.Point(141, 98);
            this.cbbAuthen.Name = "cbbAuthen";
            this.cbbAuthen.Size = new System.Drawing.Size(199, 21);
            this.cbbAuthen.TabIndex = 31;
            this.cbbAuthen.SelectedIndexChanged += new System.EventHandler(this.cbbAuthen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Authentication:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(63, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Server Name:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Enabled = false;
            this.txtPassWord.Location = new System.Drawing.Point(151, 155);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(189, 20);
            this.txtPassWord.TabIndex = 35;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(151, 129);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(189, 20);
            this.txtUserName.TabIndex = 33;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(141, 66);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(199, 20);
            this.txtServerName.TabIndex = 29;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 338);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnknCSDL);
            this.Controls.Add(this.btnldl);
            this.Controls.Add(this.cbbListDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbAuthen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServerName);
            this.Name = "FormConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConnect";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnknCSDL;
        private System.Windows.Forms.Button btnldl;
        private System.Windows.Forms.ComboBox cbbListDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAuthen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServerName;

    }
}