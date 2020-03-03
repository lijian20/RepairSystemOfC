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
    public partial class WelcomeForm : Form
    {
        LoginForm loginForm = new LoginForm();
        public WelcomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                // 单位时间添加的透明度，即欢迎界面停留时间
                this.Opacity += 0.02;
            }
            else
            {
                this.timer1.Stop();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
