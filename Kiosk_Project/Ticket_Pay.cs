using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Project
{
    //public static class UserSession
    //{
    //    // 로그인이 되었는지 여부를 저장
    //    public static bool IsLoggedIn = false;

    //    // 필요하다면 로그인한 사용자의 ID도 저장 가능
    //    public static string UserName = "";
    //}
    public partial class Ticket_Pay : Form
    {
        int adult = 0;
        int boy = 0;
        int total = 0;
        public string movie = "";
        public int floor = 0;
        public string start = "";
        public string end = "";
        public string date = "";
        public string seet = "";
        public Ticket_Pay(string movie_name, int Floor, string date, string start, string end, int Adult, int Boy, string seet)
        {
            InitializeComponent();
            this.adult = Adult;
            this.boy = Boy;
            this.movie = movie_name;
            this.floor = Floor;
            this.start = start;
            this.end = end;
            this.date = date;
            this.seet = seet;
        }

        private void Ticket_Pay_Load(object sender, EventArgs e)
        {
            label11.Text = this.adult.ToString();
            label5.Text = this.boy.ToString();
            total = (15000 * this.adult) + (12000 * this.boy);
            label9.Text = total.ToString("#,##0");
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(btn.Parent.BackColor);

            int radius = 15;
            int borderWidth = 2;
            int shadowOffset = 4;
            Color borderColor = Color.DarkGray;

            Rectangle rect = new Rectangle(0, 0, btn.Width - shadowOffset, btn.Height - shadowOffset);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            using (Brush shadowBrush = new SolidBrush(Color.FromArgb(60, Color.Black)))
            {
                GraphicsPath shadowPath = (GraphicsPath)path.Clone();
                Matrix matrix = new Matrix();
                matrix.Translate(shadowOffset, shadowOffset);
                shadowPath.Transform(matrix);
                g.FillPath(shadowBrush, shadowPath);
            }

            using (Brush btnBrush = new SolidBrush(btn.BackColor))
            {
                g.FillPath(btnBrush, path);
            }

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, path);
            }

            TextRenderer.DrawText(g, btn.Text, btn.Font, rect, btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Card_Inner card = new Card_Inner();
            if (card.ShowDialog() == DialogResult.OK)
            {
                btnPrintTicket.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NPay nPay = new NPay();
            if (nPay.ShowDialog() == DialogResult.OK)
            {
                btnPrintTicket.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KaKao kao = new KaKao();
            if (kao.ShowDialog() == DialogResult.OK)
            {
                btnPrintTicket.Visible = true;
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(movie, floor, date, start, end, adult, boy, seet);
            ticket.Show();
        }
    }
}
