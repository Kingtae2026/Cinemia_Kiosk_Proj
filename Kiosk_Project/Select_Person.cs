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
    public partial class Select_Person : Form
    {
        public string movie = "";
        public int floor = 0;
        public string start = "";
        public string end = "";
        public string date = "";
        int Adult = 0;
        int Boy = 0;
        int Selected_Num=0;
        public Select_Person(string movie_name, int Floor, string date, string start, string end, int selected_num)
        {
            InitializeComponent();
            this.Selected_Num = selected_num;
            this.movie = movie_name;
            this.floor = Floor;
            this.start = start;
            this.end = end;
            this.date = date;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(btn.Parent.BackColor);

            int borderWidth = 2;
            int shadowOffset = 4;
            Color borderColor = Color.DarkGray;

            Rectangle rect = new Rectangle(0, 0, btn.Width - shadowOffset - 1, btn.Height - shadowOffset - 1);

            // 1. 원형 경로(Path) 생성
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect); // 사각형 안에 꽉 찬 타원(원)을 추가


            // 3. 버튼 본체 채우기
            using (Brush btnBrush = new SolidBrush(btn.BackColor))
            {
                g.FillPath(btnBrush, path);
            }

            // 4. 테두리 그리기
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, path);
            }
            TextRenderer.DrawText(g, btn.Text, btn.Font, Rectangle.Round(rect), btn.ForeColor,
        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkTurquoise;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Adult = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkTurquoise;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Adult = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkTurquoise;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Adult = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkTurquoise;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;
            Adult = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkTurquoise;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            Adult = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkTurquoise;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            Boy = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkTurquoise;
            button7.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            Boy = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkTurquoise;
            button8.BackColor = Color.White;
            button7.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            Boy = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.DarkTurquoise;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button7.BackColor = Color.White;
            button11.BackColor = Color.White;
            Boy = 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.DarkTurquoise;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button7.BackColor = Color.White;
            Boy = 5;
        }

        private void button12_Paint(object sender, PaintEventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Ticket_Buy buy = new Ticket_Buy();
            if (Adult == 0 && Boy == 0)
            {
                MessageBox.Show("관람 인원을 선택해 주세요.");
                return;
            }
            Seet_Select seetForm = new Seet_Select(this.movie, this.floor, this.date, this.start, this.end, this.Adult, this.Boy, this.Selected_Num);
            seetForm.StartPosition = FormStartPosition.CenterParent;

            buy.Hide();
            this.Hide(); 
            seetForm.ShowDialog();
            this.Close();
            buy.Close();
        }
    }
}
