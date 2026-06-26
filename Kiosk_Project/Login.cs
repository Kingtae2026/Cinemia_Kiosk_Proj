using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Project
{
    public partial class Login : Form
    {
        public string ID = "Kingtae";
        //public string PW = "2026MOBLE";
        public string PW = "1234";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ID && textBox7.Text == PW)
            {
                //UserSession.IsLoggedIn = true;
                //UserSession.UserName = ID;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Kingtae" + "님! 환영합니다!!");
                this.Close();
            }
            else if (textBox1.Text == ID && textBox7.Text != PW)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다!!");
            }
            else if (textBox1.Text == ID && textBox7.Text == PW)
            {
                MessageBox.Show("아이디가 일치하지 않습니다!!");
            }
            else
            {
                MessageBox.Show("비밀번호와 아이디가 일치하지 않습니다!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox7.UseSystemPasswordChar = true;
            }
            else
            {
                textBox7.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
