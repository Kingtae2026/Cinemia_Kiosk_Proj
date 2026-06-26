using WMPLib;
using System.Drawing.Drawing2D; // 그래픽 경로(GraphicsPath)를 쓰기 위해 필요

namespace Kiosk_Project
{
    
    public partial class Kiosk_Front : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Kiosk_Front()
        {
            InitializeComponent();
        }

        private void Kiosk_Front_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\\GYU\\Gyu\\C#\\workspace\\Kiosk_Project1\\Kiosk_Project\\bin\\Debug\\net6.0-windows\\왕과 사는 남자 - 예고편.mp4";
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Interval = 100;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time1.Text = DateTime.Now.ToString("M'/'d(ddd)");
            Time2.Text = DateTime.Now.ToString("HH:mm");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_Buy buy = new Ticket_Buy();
            buy.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snack_Order snack = new Snack_Order();
            snack.Show();
        }
    }
}
