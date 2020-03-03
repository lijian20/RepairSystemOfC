namespace RepairSystem
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.ButReject = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RolesBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(159, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // RegistName
            // 
            this.RegistName.Font = new System.Drawing.Font("宋体", 14F);
            this.RegistName.Location = new System.Drawing.Point(357, 126);
            this.RegistName.Name = "RegistName";
            this.RegistName.Size = new System.Drawing.Size(238, 34);
            this.RegistName.TabIndex = 2;
            this.RegistName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(158, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码：";
            // 
            // PassWord
            // 
            this.PassWord.Font = new System.Drawing.Font("宋体", 14F);
            this.PassWord.Location = new System.Drawing.Point(357, 184);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(238, 34);
            this.PassWord.TabIndex = 4;
            // 
            // ButReject
            // 
            this.ButReject.Cursor = System.Windows.Forms.Cursors.No;
            this.ButReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButReject.Font = new System.Drawing.Font("宋体", 14F);
            this.ButReject.Location = new System.Drawing.Point(197, 349);
            this.ButReject.Name = "ButReject";
            this.ButReject.Size = new System.Drawing.Size(78, 44);
            this.ButReject.TabIndex = 5;
            this.ButReject.Text = "注册";
            this.ButReject.UseVisualStyleBackColor = true;
            this.ButReject.Click += new System.EventHandler(this.ButReject_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("宋体", 14F);
            this.Cancel.Location = new System.Drawing.Point(463, 354);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(78, 39);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(309, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "欢迎注册";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(158, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "角  色：";
            // 
            // RolesBox
            // 
            this.RolesBox.Cursor = System.Windows.Forms.Cursors.No;
            this.RolesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolesBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RolesBox.FormattingEnabled = true;
            this.RolesBox.Location = new System.Drawing.Point(357, 253);
            this.RolesBox.Name = "RolesBox";
            this.RolesBox.Size = new System.Drawing.Size(238, 31);
            this.RolesBox.TabIndex = 9;
            this.RolesBox.SelectedIndexChanged += new System.EventHandler(this.RolesBox_SelectedIndexChanged);
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 448);
            this.Controls.Add(this.RolesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ButReject);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistForm";
            this.Text = "用户注册";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWord_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Button ButReject;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RolesBox;
    }
}