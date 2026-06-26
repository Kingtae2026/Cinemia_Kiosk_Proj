using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Kiosk_Project
{
    public partial class Seet_Select : Form
    {
        List<Button> seatButtons = new List<Button>();
        int Clicked_Count = 0;
        int Max_Person = 0;
        int Selected_Num = 0;
        int disableCount = 0;
        int Adult = 0;
        int Boy = 0;
        public string movie = "";
        public int floor = 0;
        public string start = "";
        public string end = "";
        public string date = "";
        public string seet = "";

        public Seet_Select(string movie_name, int Floor, string date, string start, string end, int Adult, int Boy, int selected_num)
        {
            InitializeComponent();
            this.Adult = Adult;
            this.Boy = Boy;
            this.Max_Person = Adult + Boy;
            this.Selected_Num = selected_num;
            this.movie = movie_name;
            this.floor = Floor;
            this.start = start;
            this.end = end;
            this.date = date;
        }

        private void CloseForm()
        {
            // 열려있는 모든 폼을 체크함
            // 리스트를 뒤에서부터 검사해야 오류가 나지 않습니다.
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form f = Application.OpenForms[i];

                // 첫 번째 폼(예: Form1 또는 Main_Form)의 이름이 아니면 모두 닫음
                if (f.Name != "Ticket_Pay") // 실제 본인의 첫 폼 클래스 이름을 적으세요.
                {
                    f.Close();
                }
            }
        }

        private void ReturnToMain()
        {
            Application.Restart();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time1.Text = DateTime.Now.ToString("yyyy.MM.dd dddd");
            Time2.Text = DateTime.Now.ToString(" hh:mm tt", new System.Globalization.CultureInfo("en-US")).ToLower();
        }

        private void Seet_Select_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

            // 반복문으로 패널이나 폼 내의 모든 버튼 찾기
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Text != "S C R E E N") // 스크린 버튼 제외
                {
                    seatButtons.Add(btn);
                    btn.Click += SeatButton_Click;
                }
            }
            if (this.Selected_Num > 0)
            {
                DisableRandomSeats();
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            //  누가 눌렸는지 확인 (sender를 Button으로 변환)
            Button clickedSeat = sender as Button;

            if (clickedSeat.BackColor == Color.Blue)
            {
                clickedSeat.BackColor = Color.Gray;
                clickedSeat.ForeColor = Color.White;
                Clicked_Count--;
                textBox7.Text = textBox7.Text.Replace(clickedSeat.Tag.ToString() + "\r\n", "");
                label11.Text = Clicked_Count.ToString();
                seet = textBox7.Text;
                return;
            }
            if (Clicked_Count >= Max_Person)
            {
                MessageBox.Show($"이미 설정하신 인원({Max_Person}명)만큼 좌석을 모두 선택하셨습니다.",
                                "인원 초과", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clickedSeat != null)
            {
                string seatInfo = clickedSeat.Tag.ToString();

                // 테스트용 메시지 박스 (정보가 잘 오는지 확인용)
                //MessageBox.Show($"선택한 좌석: {seatInfo}\n");
                textBox7.Text += $"{seatInfo}";
                textBox7.Text += "\r\n";
                clickedSeat.BackColor = Color.Blue;
                clickedSeat.FlatAppearance.BorderColor = Color.Blue;
                clickedSeat.ForeColor = Color.White;
                Clicked_Count++;
                label11.Text = Clicked_Count.ToString();
                seet = textBox7.Text;
            }

        }

        private void button2_Paint(object sender, PaintEventArgs e)
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

        public void DisableRandomSeats()
        {
            Random rand = new Random();

            if (seatButtons == null || seatButtons.Count == 0 || this.Selected_Num <= 0) return;
            // 현재 활성화된 좌석들만 골라내기 (이미 비활성화된 곳 중복 방지)
            var availableSeats = seatButtons.Where(b => b.Enabled).ToList();

            // 요청한 개수가 남은 좌석보다 많으면 조절
            int actualDisableCount = Math.Min(this.Selected_Num, availableSeats.Count);

            for (int i = 0; i < actualDisableCount; i++)
            {
                // 랜덤 인덱스 선택
                int index = rand.Next(availableSeats.Count);

                // 해당 버튼 비활성화 및 시각적 처리
                availableSeats[index].Enabled = false;
                availableSeats[index].BackColor = Color.Red; // 예약된 느낌 주기
                availableSeats[index].Text = "X";

                // 선택된 좌석은 리스트에서 제거하여 중복 방지
                availableSeats.RemoveAt(index);
            }
        }
        public void ResetSeats()
        {
            foreach (var btn in seatButtons)
            {
                btn.Enabled = true;           // 다시 클릭 가능하게
                btn.BackColor = Color.Gray;  // 원래 좌석 색상으로 (사진 속 회색)
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Ticket tick = new Ticket(movie, floor, date, start, end, Adult, Boy, seet);
            Ticket_Pay ticket = new Ticket_Pay(this.movie, this.floor, this.date, this.start, this.end, this.Adult, this.Boy, this.seet);
            ticket.Show();
            //CloseForm();
            //this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }
    }
}
