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
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
            // 加载下拉列表
            Role_ComboBox();
        }

        
        // 清空输入
        void ClearAll()
        {
            RegistName.Text = "";
            PassWord.Text = "";
        }

        // 注册下拉列表方法
        public void Role_ComboBox()
        {
            RolesBox.Items.Add("学生");
            RolesBox.Items.Add("维修工程师");
            this.RolesBox.SelectedIndex = 0;
        }



        // 判断注册用户是否已经存在
        bool UserName(string userName)
        {
            string sqlStr = "select userName from user_info where userName='" + RegistName.Text.Trim() + "'";
            DataSet ds =  DBconn.getData(sqlStr);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }


        private void ButReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegistName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("用户名不能为空！", "提示");
                    RegistName.Focus();
                }else if (PassWord.Text.Trim().Equals(""))
                {
                    MessageBox.Show("密码不能为空！", "提示");
                    PassWord.Focus();
                }else if (UserName(RegistName.Text.Trim()))
                {
                    MessageBox.Show("用户名已经存在！", "提示");
                    ClearAll();
                }
                else
                {
                    
                    string sqlStr = "insert user_info (userName, userPwd, roles) values('" + RegistName.Text.Trim() + "','" + PassWord.Text.Trim() + "','" + RolesBox.Text.Trim() + "')";
                    if (DBconn.PDData(sqlStr))
                    {
                        MessageBox.Show("用户" + RegistName.Text.Trim() + "注册成功!");
                    }
                    this.Close();
                }
            }catch(Exception ex)            {
                DBconn.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
            }
        }

        // 取消注册
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认取消注册?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PassWord_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButReject_Click(sender, e);

            }
        }

        private void RolesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
