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
    public partial class Ticket_Buy : Form
    {
        public Ticket_Buy()
        {
            InitializeComponent();
        }

        private void Ticket_Buy_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time1.Text = DateTime.Now.ToString("yyyy.MM.dd dddd");
            Time2.Text = DateTime.Now.ToString(" hh:mm tt", new System.Globalization.CultureInfo("en-US")).ToLower();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(btn.Parent.BackColor);

            int radius = 50;
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.OrangeRed;
            button2.BackColor = Color.Gray; ;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            label1.BackColor = Color.OrangeRed;
            label2.BackColor = Color.OrangeRed;
            label3.BackColor = Color.OrangeRed;
            label4.BackColor = Color.Gray;
            label5.BackColor = Color.Gray;
            label6.BackColor = Color.Gray;
            label7.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            label9.BackColor = Color.Gray;
            label10.BackColor = Color.Gray;
            label11.BackColor = Color.Gray;
            label12.BackColor = Color.Gray;
            label13.BackColor = Color.Gray;
            label14.BackColor = Color.Gray;
            label15.BackColor = Color.Gray;

            panel1.Controls.Clear();
            Ticket_03 ticket03 = new Ticket_03();
            //ticket03.StartPosition = FormStartPosition.Manual;
            //ticket03.Location = new Point(107, 400);
            ticket03.TopLevel = false;
            ticket03.FormBorderStyle = FormBorderStyle.None;
            ticket03.Dock = DockStyle.Fill;
            panel1.Controls.Add(ticket03);
            ticket03.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
            button1.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label4.BackColor = Color.OrangeRed;
            label5.BackColor = Color.OrangeRed;
            label6.BackColor = Color.OrangeRed;
            label7.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            label9.BackColor = Color.Gray;
            label10.BackColor = Color.Gray;
            label11.BackColor = Color.Gray;
            label12.BackColor = Color.Gray;
            label13.BackColor = Color.Gray;
            label14.BackColor = Color.Gray;
            label15.BackColor = Color.Gray;

            panel1.Controls.Clear();
            Ticket_04 ticket04 = new Ticket_04();
            ticket04.TopLevel = false;
            ticket04.FormBorderStyle = FormBorderStyle.None;
            ticket04.Dock = DockStyle.Fill;
            panel1.Controls.Add(ticket04);
            ticket04.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.OrangeRed;
            button2.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label7.BackColor = Color.OrangeRed;
            label8.BackColor = Color.OrangeRed;
            label9.BackColor = Color.OrangeRed;
            label4.BackColor = Color.Gray;
            label5.BackColor = Color.Gray;
            label6.BackColor = Color.Gray;
            label10.BackColor = Color.Gray;
            label11.BackColor = Color.Gray;
            label12.BackColor = Color.Gray;
            label13.BackColor = Color.Gray;
            label14.BackColor = Color.Gray;
            label15.BackColor = Color.Gray;

            panel1.Controls.Clear();
            Ticket_05 ticket05 = new Ticket_05();
            ticket05.TopLevel = false;
            ticket05.FormBorderStyle = FormBorderStyle.None;
            ticket05.Dock = DockStyle.Fill;
            panel1.Controls.Add(ticket05);
            ticket05.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.OrangeRed;
            button3.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label10.BackColor = Color.OrangeRed;
            label11.BackColor = Color.OrangeRed;
            label12.BackColor = Color.OrangeRed;
            label13.BackColor = Color.Gray;
            label5.BackColor = Color.Gray;
            label6.BackColor = Color.Gray;
            label7.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            label9.BackColor = Color.Gray;
            label13.BackColor = Color.Gray;
            label14.BackColor = Color.Gray;
            label15.BackColor = Color.Gray;

            panel1.Controls.Clear();
            Ticket_06 ticket06 = new Ticket_06();
            ticket06.TopLevel = false;
            ticket06.FormBorderStyle = FormBorderStyle.None;
            ticket06.Dock = DockStyle.Fill;
            panel1.Controls.Add(ticket06);
            ticket06.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.OrangeRed;
            button4.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label13.BackColor = Color.OrangeRed;
            label14.BackColor = Color.OrangeRed;
            label15.BackColor = Color.OrangeRed;
            label4.BackColor = Color.Gray;
            label5.BackColor = Color.Gray;
            label6.BackColor = Color.Gray;
            label7.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            label9.BackColor = Color.Gray;
            label10.BackColor = Color.Gray;
            label11.BackColor = Color.Gray;
            label12.BackColor = Color.Gray;

            panel1.Controls.Clear();
            Ticket_07 ticket07 = new Ticket_07();
            ticket07.TopLevel = false;
            ticket07.FormBorderStyle = FormBorderStyle.None;
            ticket07.Dock = DockStyle.Fill;
            panel1.Controls.Add(ticket07);
            ticket07.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
