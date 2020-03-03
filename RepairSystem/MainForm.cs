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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ComType_ComboBox();
        }

        private void LabUser_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            //mainForm.LabUser = LoginForm.
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认要退出吗？", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
        void ClearAll()
        {
            TextAddress.Text = "";
            TextContent.Text = "";
            DateRepair.Value = DateTime.Now;
            ComType.SelectedIndex = -1;
        }

        private void ButRepair_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.验证输入内容是否有效
                if (TextAddress.Text.Trim().Equals(""))
                {
                    MessageBox.Show("报修地点不能为空", "提示");
                    TextAddress.Focus();
                    return;
                }else if (TextContent.Text.Trim().Equals(""))
                {
                    MessageBox.Show("报修内容不能为空", "提示");
                    TextContent.Focus();
                    return;
                }else if(ComType.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择报修类型", "提示");
                    ComType.Focus();
                    return;
                }
                // 验证数据库中是否已经有相同的报修
                string id = "select userId from user_info where userName = '"+LabUser.Text+"'";
                DataSet user = DBconn.getData(id);
                string sqlStr = "select repairId,repairCount from repairtable where userId = '" + user.Tables[0].Rows[0][0] + "'";

                
                DataSet ds = DBconn.getData(sqlStr);
                //如果ds里面不存在数据，说明这个用户第一次报修，直接插入新的记录
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string sqlInsert = "insert into repairtable(userId,repairContent,repairDate," +
                        "repairStatus,repairAddress,repairType,repairCount)values('"+ user.Tables[0].Rows[0][0] + "','"+ TextContent.Text + "','"+DateRepair.Value+"','"+"待维修"+"','"+TextAddress.Text+"','"+ ComType.Text +"','"+ 1 +"')";
                    DBconn.upData(sqlInsert);
                    MessageBox.Show("报修成功!");
                    ClearAll();
                }
                else
                {
                    //否则的话就是repairtable表里已经有了LanUser里的这个用户。目的就是更新这个用户的报修次数，并插入新的记录
                    int count = ds.Tables[0].Rows.Count;
                    string sqlInsert = "insert into repairtable(userId,repairContent,repairDate," +
                       "repairStatus,repairAddress,repairType,repairCount)values('" + user.Tables[0].Rows[0][0] + "','" + TextContent.Text + "','" + DateRepair.Value + "','" + "待维修" + "','" + TextAddress.Text + "','" + ComType.Text + "','"+ (count+1) + "')";
                    DBconn.upData(sqlInsert);
                    MessageBox.Show("报修成功!");
                    ClearAll();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("报修出错：" + ex.Message);
                TextContent.Focus();
            }
            finally
            {
                // 最后关闭数据库
                DBconn.conn.Close();
            }
        }

        // 报修下拉列表设置
        public void ComType_ComboBox()
        {
            ComType.Items.Add("电器");
            ComType.Items.Add("自来水");
            ComType.Items.Add("其他");
            this.ComType.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
