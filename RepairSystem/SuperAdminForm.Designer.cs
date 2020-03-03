namespace RepairSystem
{
    partial class SuperAdminForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPwdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.userGridView);
            this.toolStripContainer1.ContentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdColumn,
            this.UserNameColumn,
            this.UserPwdColumn,
            this.RolesColumn,
            this.Modify});
            this.userGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridView.Location = new System.Drawing.Point(0, 0);
            this.userGridView.Margin = new System.Windows.Forms.Padding(5);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowTemplate.Height = 27;
            this.userGridView.Size = new System.Drawing.Size(800, 425);
            this.userGridView.TabIndex = 0;
            this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellContentClick);
            this.userGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.userGridView_RowPostPaint);
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.HeaderText = "用户ID";
            this.UserIdColumn.Name = "UserIdColumn";
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "用户名";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Width = 120;
            // 
            // UserPwdColumn
            // 
            this.UserPwdColumn.HeaderText = "用户密码";
            this.UserPwdColumn.Name = "UserPwdColumn";
            this.UserPwdColumn.Width = 120;
            // 
            // RolesColumn
            // 
            this.RolesColumn.HeaderText = "用户角色";
            this.RolesColumn.Name = "RolesColumn";
            this.RolesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RolesColumn.Width = 120;
            // 
            // Modify
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.Modify.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modify.HeaderText = "修改";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "修改";
            // 
            // SuperAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "SuperAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuperAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.SuperAdminForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPwdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RolesColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
    }
}