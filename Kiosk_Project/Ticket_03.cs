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
    public partial class Ticket_03 : Form
    {
        public string movie = "";
        public int floor = 0;
        public string start = "";
        public string end = "";
        public string date = "";
        public int selected_Num = 0;
        bool isLoggedIn = false;
        public Ticket_03()
        {
            InitializeComponent();
        }

        private bool RunLoginCheck()
        {
            if (isLoggedIn) return true; // 이미 로그인 되어있으면 바로 통과

            MessageBox.Show("로그인이 필요한 서비스입니다!!");
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                isLoggedIn = true; // 로그인 성공 시 상태 저장
                return true;
            }
            return false; // 로그인 취소 시
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (RunLoginCheck())
            {
                movie = "왕과 사는 남자";
                floor = 1;
                start = textBox3.Text;
                end = textBox4.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 48);
                Person.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (RunLoginCheck())
            { 
                movie = "왕과 사는 남자";
                floor = 3;
                start = textBox8.Text;
                end = textBox12.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 28);
                Person.Show();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (RunLoginCheck())
            {
                movie = "왕과 사는 남자";
                floor = 4;
                start = textBox18.Text;
                end = textBox22.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 32);
                Person.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RunLoginCheck())
            {
                movie = "왕과 사는 남자";
                floor = 2;
                start = textBox13.Text;
                end = textBox17.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 17);
                Person.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {   if (RunLoginCheck())
            { 
                movie = "휴민트";
                floor = 3;
                start = textBox25.Text;
                end = textBox36.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 37);
                Person.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (RunLoginCheck())
            { 
                movie = "휴민트";
                floor = 2;
                start = textBox27.Text;
                end = textBox40.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 26);
                Person.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (RunLoginCheck())
            {
                movie = "휴민트";
                floor = 1;
                start = textBox31.Text;
                end = textBox44.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 22);
                Person.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (RunLoginCheck())
            {
                movie = "휴민트";
                floor = 5;
                start = textBox29.Text;
                end = textBox42.Text;
                date = "3/3(화)";
                Select_Person Person = new Select_Person(movie, floor, date, start, end, 45);
                Person.Show();
            }
        }
    }
}
