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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // 获取数据到页面
            string strSelect = "select * from repairtable";
            AddData(strSelect);
        }

        // 修改按钮
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                if(dataGridView1.Columns[e.ColumnIndex].Name == "ColumnRe" && e.ColumnIndex >= 0)
                {
                    //说明点击的列是DataGridViewButtonColumn列
                    DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                   // MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    // 获取需要修改的状态
                    string strStatus = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                    if (strStatus.Equals("待维修"))
                    {
                        // 弹出消息框，并获取消息框的返回值
                        DialogResult dr = MessageBox.Show("是否已经维修？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(dr == DialogResult.Yes)
                        {
                            // 修改状态数据库语句
                            string sql = "update repairtable set repairStatus = '"+"已维修"+"' where repairId = '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'";
                            DBconn.upData(sql);
                            // 修改窗体状态语句
                            dataGridView1.CurrentRow.Cells[6].Value = "已维修";
                            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Style.BackColor = Color.Aqua;
                            
                        }
                    }
                    else
                    {
                        // 弹出消息框，并获取消息框的返回值
                        DialogResult dr = MessageBox.Show("是否未维修？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            // 修改状态数据库语句
                            string sql = "update repairtable set repairStatus = '" + "待维修" + "'where repairId = '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'";
                            DBconn.upData(sql);
                            // 修改窗体状态语句
                            dataGridView1.CurrentRow.Cells[6].Value = "待维修";
                            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Style.BackColor = Color.Pink;
                        }
                    }
                
                }
            }catch(Exception ex)
            {
                MessageBox.Show("修改失败" + ex.Message);
            }
            finally
            {
                // 最后关闭数据库
                DBconn.conn.Close();
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认要退出吗？", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        // 菜单-全部
        private void ALL_Click_1(object sender, EventArgs e)
        {
            // 获取数据到页面
            string strSelect = "select * from repairtable";
            AddData(strSelect);
        }

        // 菜单-待维修
        private void Ready_Click(object sender, EventArgs e)
        {
            // 获取数据到页面
            string strSelect = "select * from repairtable where repairStatus = '" + "待维修" + "'";

            AddData(strSelect);
        }

        // 菜单-已维修
        private void Already_Click(object sender, EventArgs e)
        {
            // 获取数据到页面
            string strSelect = "select * from repairtable where repairStatus = '" + "已维修" + "'";

            AddData(strSelect);
        }

        // 加载数据到列表方法
        public void AddData(string  sql)
        {
            try
            {
                // 首先清空页面
                while (this.dataGridView1.Rows.Count != 0)
                {
                    this.dataGridView1.Rows.RemoveAt(0);
                }

                DataSet ds = DBconn.getData(sql);

                int count = ds.Tables[0].Rows.Count;
                // 逐行加载数据到列表
                for (int i = 0; i < count; i++)
                {
                    string id = ds.Tables[0].Rows[i][0].ToString().Trim();
                    string userid = ds.Tables[0].Rows[i][1].ToString().Trim();
                    string content = ds.Tables[0].Rows[i][2].ToString().Trim();
                    string dateTime = ds.Tables[0].Rows[i][3].ToString().Trim();
                    string status = ds.Tables[0].Rows[i][4].ToString().Trim();
                    string address = ds.Tables[0].Rows[i][5].ToString().Trim();
                    string type = ds.Tables[0].Rows[i][6].ToString().Trim();

                    // 获取用户名
                    string sqlName = "select userName from user_info where userId = '" + int.Parse(userid) + "'";
                    DataSet dataSet = DBconn.getData(sqlName);

                    // 加载数据到列表
                    this.dataGridView1.Rows.Add(id, dataSet.Tables[0].Rows[0][0], content, dateTime, address, type, status);

                    // 设置按键背景色
                    if (status.Equals("待维修"))
                    {
                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Pink;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Aqua;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取数据失败" + ex.Message);
            }
            finally
            {
                // 关闭数据库
                DBconn.conn.Close();
            }
        }

        // 显示行号
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font, rect,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
