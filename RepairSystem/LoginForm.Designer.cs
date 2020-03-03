namespace RepairSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonRegist = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.Roles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(317, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(317, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(317, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "角色：";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonLogin.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(321, 278);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(315, 54);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(396, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "用户登录";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ButtonRegist
            // 
            this.ButtonRegist.Font = new System.Drawing.Font("宋体", 8F);
            this.ButtonRegist.Location = new System.Drawing.Point(321, 347);
            this.ButtonRegist.Name = "ButtonRegist";
            this.ButtonRegist.Size = new System.Drawing.Size(78, 23);
            this.ButtonRegist.TabIndex = 6;
            this.ButtonRegist.Text = "注册";
            this.ButtonRegist.UseVisualStyleBackColor = true;
            this.ButtonRegist.Click += new System.EventHandler(this.ButtonRegist_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 8F);
            this.buttonCancel.Location = new System.Drawing.Point(557, 347);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.AliceBlue;
            this.userName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(414, 105);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(222, 27);
            this.userName.TabIndex = 8;
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passWord.Location = new System.Drawing.Point(414, 158);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(222, 27);
            this.passWord.TabIndex = 9;
            this.passWord.TextChanged += new System.EventHandler(this.passWord_TextChanged);
            this.passWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWord_TextChanged);
            // 
            // Roles
            // 
            this.Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roles.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Roles.FormattingEnabled = true;
            this.Roles.Location = new System.Drawing.Point(414, 211);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(222, 25);
            this.Roles.TabIndex = 10;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 419);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonRegist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报修系统登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonRegist;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.ComboBox Roles;
    }
}