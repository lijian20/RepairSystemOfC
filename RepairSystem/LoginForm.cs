using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RepairSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            // 在显示登录窗口前先显示欢迎界面
            /*
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            // 欢迎窗口停留2s
            System.Threading.Thread.Sleep(2000);
            welcomeForm.Close();*/

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 调用下拉列表函数
            Role_ComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                // 1. 验证输入数据是否合法
                // 获取文本框的值
                string name = this.userName.Text.Trim();
                string pwd = this.passWord.Text.Trim();
                string role = this.Roles.Text.Trim();

                // 验证输入的值
                if (name.Equals(""))
                {
                    MessageBox.Show("用户名不能为空！","提示");
                    // 获取焦点
                    userName.Focus();
                    return;
                }else if (pwd.Equals(""))
                {
                    MessageBox.Show("密码不能为空", "提示");
                    // 获取焦点
                    passWord.Focus();
                    return;
                }
                else if (Roles.Equals(""))
                {
                    MessageBox.Show("身份不能为空", "提示");
                    // 获取焦点
                    Roles.Focus();

                    return;
                }
                // 数据库查询用户信息
                string sqlStr = "select userName, userPwd, roles from user_info where userName = '"+name+"'";
                DataSet ds = DBconn.getData(sqlStr);
                // 一个大坑，数据库取出来的数据的字符串中有空字符，需要使用trim()去掉
                
                // string roles = ds.Tables[0].Rows[0][2].ToString().Trim();
                int count = ds.Tables[0].Rows.Count;
                if (count==0)
                {
                    MessageBox.Show("用户名不存在,请重新输入", "提示");
                    // 文本框置空
                    userName.Text = "";
                    passWord.Text = "";
                    Roles.Text = "";
                    userName.Focus();
                }else if(ds.Tables[0].Rows[0][1].ToString().Trim() == pwd)
                {

                    string roles = ds.Tables[0].Rows[0][2].ToString().Trim();
                    // 验证身份
                    if (roles.Equals("后勤老师")&&roles.Equals(role))
                    {
                        
                        MessageBox.Show("恭喜您登录成功!", "提示");
                        // 验证通过，页面跳转
                        SuperAdminForm superAdminForm = new SuperAdminForm();
                        this.Hide();
                        superAdminForm.Show();

                    }
                    else if (roles.Equals("维修工程师") && roles.Equals(role))
                    {
                        MessageBox.Show("恭喜您登录成功!", "提示");
                        // 验证通过，页面跳转
                        AdminForm adminForm = new AdminForm();
                        this.Hide();
                        adminForm.Show();
                    }
                    else if (roles.Equals("学生") && roles.Equals(role))
                    {
                        
                        // 验证通过，页面跳转
                        MessageBox.Show("恭喜您登录成功!", "提示");

                        MainForm mainForm = new MainForm();
                        mainForm.LabUser.Text = name;
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("请正确选择您的身份！");
                        Roles.Text = "";
                        userName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入！");
                    userName.Text = "";
                    passWord.Text = "";
                    Roles.Text = "";
                    userName.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("登录异常：" + ex.Message);
                userName.Text = "";
                passWord.Text = "";
                Roles.Text = "";
                userName.Focus();
            }
            finally
            {
                // 最后关闭数据库
                DBconn.conn.Close();
            }
        }

        // 角色下拉列表设置
        public void Role_ComboBox()
        {
            Roles.Items.Add("学生");
            Roles.Items.Add("维修工程师");
            Roles.Items.Add("后勤老师");
            this.Roles.SelectedIndex = 0;
        }

        // 捕获选定列表中的内容
        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (Roles.SelectedItem.ToString())
            {
                case "学生": MessageBox.Show("学生");break;
                case "维修工程师": MessageBox.Show("维修工程师"); break;
                case "后勤老师": MessageBox.Show("后勤老师"); break;
            }*/

        }

        private void ButtonRegist_Click(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm();
            registForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void passWord_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
