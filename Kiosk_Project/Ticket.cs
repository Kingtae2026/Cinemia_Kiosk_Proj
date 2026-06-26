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
    public partial class Ticket : Form
    {
        int Adult = 0;
        int Boy = 0;
        public string movie = "";
        public int floor = 0;
        public string start = "";
        public string end = "";
        public string date = "";
        public string seet = "";
        public Ticket(string movie_name, int Floor, string date, string start, string end, int Adult, int Boy, string seet)
        {
            InitializeComponent();
            this.movie = movie_name;
            this.floor = Floor;
            this.start = start;
            this.end = end;
            this.date = date;
            this.seet = seet;
            this.Adult = Adult;
            this.Boy = Boy;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            label1.Text = movie;
            label3.Text = floor.ToString();
            label6.Text = date;
            label7.Text = start;
            label9.Text = end;
            label11.Text = Adult.ToString();
            label13.Text = Boy.ToString();
            textBox7.Text = seet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time1.Text = DateTime.Now.ToString("yyyy.MM.dd dddd");
            Time2.Text = DateTime.Now.ToString(" hh:mm tt", new System.Globalization.CultureInfo("en-US")).ToLower();
        }
    }   
}
