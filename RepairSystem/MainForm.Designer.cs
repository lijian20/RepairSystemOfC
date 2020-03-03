namespace RepairSystem
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextContent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateRepair = new System.Windows.Forms.DateTimePicker();
            this.ComType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(269, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "报修登记";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "欢迎";
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabUser.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabUser.Location = new System.Drawing.Point(186, 148);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(26, 27);
            this.LabUser.TabIndex = 2;
            this.LabUser.Text = "1";
            this.LabUser.Click += new System.EventHandler(this.LabUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(89, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "报修地点：";
            // 
            // TextAddress
            // 
            this.TextAddress.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextAddress.Location = new System.Drawing.Point(94, 267);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(248, 32);
            this.TextAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(89, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "报修内容：";
            // 
            // TextContent
            // 
            this.TextContent.Location = new System.Drawing.Point(94, 399);
            this.TextContent.Name = "TextContent";
            this.TextContent.Size = new System.Drawing.Size(248, 123);
            this.TextContent.TabIndex = 6;
            this.TextContent.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(510, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "报修日期：";
            // 
            // DateRepair
            // 
            this.DateRepair.CalendarFont = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DateRepair.Location = new System.Drawing.Point(515, 269);
            this.DateRepair.Margin = new System.Windows.Forms.Padding(6);
            this.DateRepair.Name = "DateRepair";
            this.DateRepair.Size = new System.Drawing.Size(195, 25);
            this.DateRepair.TabIndex = 8;
            // 
            // ComType
            // 
            this.ComType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComType.FormattingEnabled = true;
            this.ComType.Location = new System.Drawing.Point(515, 387);
            this.ComType.Name = "ComType";
            this.ComType.Size = new System.Drawing.Size(195, 30);
            this.ComType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(510, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "报修类型：";
            // 
            // ButRepair
            // 
            this.ButRepair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButRepair.Font = new System.Drawing.Font("华文新魏", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButRepair.Location = new System.Drawing.Point(515, 462);
            this.ButRepair.Name = "ButRepair";
            this.ButRepair.Size = new System.Drawing.Size(195, 60);
            this.ButRepair.TabIndex = 11;
            this.ButRepair.Text = "立即报修";
            this.ButRepair.UseVisualStyleBackColor = false;
            this.ButRepair.Click += new System.EventHandler(this.ButRepair_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 557);
            this.Controls.Add(this.ButRepair);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComType);
            this.Controls.Add(this.DateRepair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报修系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TextContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateRepair;
        private System.Windows.Forms.ComboBox ComType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButRepair;
    }
}