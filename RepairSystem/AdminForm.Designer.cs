namespace RepairSystem
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Already = new System.Windows.Forms.ToolStripMenuItem();
            this.Ready = new System.Windows.Forms.ToolStripMenuItem();
            this.ALL = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Already,
            this.Ready,
            this.ALL});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(51, 24);
            this.menu.Text = "菜单";
            // 
            // Already
            // 
            this.Already.Name = "Already";
            this.Already.Size = new System.Drawing.Size(129, 26);
            this.Already.Text = "已维修";
            this.Already.Click += new System.EventHandler(this.Already_Click);
            // 
            // Ready
            // 
            this.Ready.Name = "Ready";
            this.Ready.Size = new System.Drawing.Size(129, 26);
            this.Ready.Text = "待维修";
            this.Ready.Click += new System.EventHandler(this.Ready_Click);
            // 
            // ALL
            // 
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(129, 26);
            this.ALL.Text = "全部";
            this.ALL.Click += new System.EventHandler(this.ALL_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColumnUser,
            this.ColumnContent,
            this.ColumnDate,
            this.ColumnAdd,
            this.ColumnType,
            this.ColumnStatus,
            this.ColumnRe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1407, 704);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "用户名";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnContent
            // 
            this.ColumnContent.HeaderText = "维修内容";
            this.ColumnContent.Name = "ColumnContent";
            this.ColumnContent.ReadOnly = true;
            this.ColumnContent.Width = 200;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "报修时间";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "地点";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.ReadOnly = true;
            this.ColumnAdd.Width = 200;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "类型";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            
            this.ColumnStatus.HeaderText = "状态";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnRe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ColumnRe.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnRe.HeaderText = "修改";
            this.ColumnRe.Name = "ColumnRe";
            this.ColumnRe.ReadOnly = true;
            this.ColumnRe.Text = "修改";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1407, 732);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维修列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem Already;
        private System.Windows.Forms.ToolStripMenuItem Ready;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem ALL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnRe;
    }
}