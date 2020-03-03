using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSystem
{
    public partial class SuperAdminForm : Form
    {
        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void SuperAdminForm_Load(object sender, EventArgs e)
        {
            // 右下角时间控制
            this.toolStripStatusLabel1.Alignment = ToolStripItemAlignment.Right;
            this.toolStripStatusLabel1.Text = "当前日期为：" + DateTime.Now.ToShortDateString();

            // 设置下拉列表
            this.RolesColumn.Items.Add("后勤老师");
            this.RolesColumn.Items.Add("维修工程师");
            this.RolesColumn.Items.Add("学生");

            // 设置id无法修改
            userGridView.Columns[0].ReadOnly = true;

            // 从数据库中取数据，加载到列表控件上
            try
            {
                // SQL语句
                string sql = "select * from user_info";
                // 1.连接数据库，并执行SQL语句
                DataSet dataSet = DBconn.getData(sql);

                // 2.通过for循环加载数据
                for(int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    // 定义字符串接收对应数据
                    string userId = dataSet.Tables[0].Rows[i][0].ToString();
                    string userName = dataSet.Tables[0].Rows[i][1].ToString();
                    string userPwd = dataSet.Tables[0].Rows[i][2].ToString();
                    string userRoles = dataSet.Tables[0].Rows[i][3].ToString();


                    this.userGridView.Rows.Add(userId, userName, userPwd);

                    //MessageBox.Show( this.RolesColumn.Items[i].ToString());

                    this.userGridView.Rows[i].Cells[3].Style.NullValue = userRoles;
                    // this.userGridView.DataSource = dataSet.Tables[0];

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载出错："+ex.Message);
            }
            finally
            {
                // 关闭数据库连接
                DBconn.conn.Close();
            }
        }

        // 修改按钮
        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 验证选择行
                if(userGridView.Columns[e.ColumnIndex].Name == "Modify" && e.ColumnIndex >= 0)
                {
                    // 获取需要修改的用户信息
                    string userId = userGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                    string userName = userGridView.CurrentRow.Cells[1].Value.ToString().Trim();
                    string userPwd = userGridView.CurrentRow.Cells[2].Value.ToString().Trim(); 
                    string userRoles = userGridView[3, e.RowIndex].EditedFormattedValue.ToString();

                    if (userName.Equals(""))
                    {
                        MessageBox.Show("用户名不能为空！");
                        return;
                    }else if (userPwd.Equals(""))
                    {
                        MessageBox.Show("用户密码不能为空！");
                        return;
                    }else if (userRoles.Equals(""))
                    {
                        MessageBox.Show("用户角色不能为空！");
                        return;
                    }
                    else
                    {
                        // 在数据库中修改
                        string sql = "update user_info set userName = '" + userName + "', userPwd = '" + userPwd + "', roles = '" + userRoles + "' where userId = '" + int.Parse(userId) + "'";

                        //DataSet dataSet = DBconn.upData(sql);

                        if (DBconn.PDData(sql))
                        {
                            MessageBox.Show("用户：" + userName + " 修改成功");
                        }
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("修改失败：" + ex.Message);
            }
            finally
            {
                // 关闭数据库连接
                DBconn.conn.Close();
            }
        }

        // 右上角关闭按钮
        private void SuperAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认要退出吗？", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        // 显示行号
        private void userGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                userGridView.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                userGridView.RowHeadersDefaultCellStyle.Font, rect,
                userGridView.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        
    }
}
