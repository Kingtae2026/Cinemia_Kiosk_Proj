using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Kiosk_Project
{
    public partial class Snack_Order : Form
    {
        private class MenuItem
        {
            public string Name;
            public int Price;
            public int Quantity;
            public string ImagePath;

            public MenuItem(string name, int price, string imagePath)
            {
                Name = name;
                Price = price;
                Quantity = 0;
                ImagePath = imagePath;
            }
        }

        private List<MenuItem> menuItems = new List<MenuItem>
        {
            new MenuItem("팝콘",        7000, "팝콘.jpg"),
            new MenuItem("콜라",        3000, "콜라.jpg"),
            new MenuItem("사이다",      3000, "사이다.jpg"),
            new MenuItem("오징어 다리", 6000, "오징어 다리.jpg"),
            new MenuItem("카스 맥주",   5000, "카스 맥주.jpg"),
            new MenuItem("테라 맥주",   5000, "테라 맥주.jpg"),
            new MenuItem("한맥 맥주",   5000, "한맥 맥주.jpg"),
        };

        public Snack_Order()
        {
            InitializeComponent();
        }

        private void Snack_Order_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            RenderMenuCards();
            UpdateTotal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy.MM.dd dddd");
            lblTime.Text = DateTime.Now.ToString(" hh:mm tt", new CultureInfo("en-US")).ToLower();
        }

        // 이미지를 여러 경로에서 순서대로 찾아 반환 (못 찾으면 null)
        private Image FindImage(string fileName)
        {
            // 실행파일이 있는 폴더부터 위로 올라가며 탐색
            string start = Application.StartupPath;
            string[] candidates = new string[]
            {
                Path.Combine(start, fileName),
                Path.Combine(start, "..", fileName),
                Path.Combine(start, "..", "..", fileName),
                Path.Combine(start, "..", "..", "..", fileName),
                Path.Combine(start, "..", "..", "..", "bin", fileName),
            };

            foreach (var p in candidates)
            {
                string full = Path.GetFullPath(p);
                if (File.Exists(full))
                {
                    try { return Image.FromFile(full); }
                    catch { }
                }
            }
            return null;
        }

        private void RenderMenuCards()
        {
            panelMenu.Controls.Clear();

            int cardW = 175, cardH = 230;
            int gapX = 20, gapY = 16;
            int col = 0, row = 0;
            int padX = 30, padY = 16;

            foreach (var item in menuItems)
            {
                Panel card = new Panel
                {
                    Size = new Size(cardW, cardH),
                    Location = new Point(padX + col * (cardW + gapX), padY + row * (cardH + gapY)),
                    BackColor = Color.White,
                    Tag = item
                };
                card.Paint += (s, e2) =>
                {
                    Graphics g = e2.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath gp = RoundedRect(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 12))
                    using (Pen pen = new Pen(Color.LightGray, 1.5f))
                        g.DrawPath(pen, gp);
                };

                PictureBox pb = new PictureBox
                {
                    Size = new Size(cardW - 10, 128),
                    Location = new Point(5, 5),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.WhiteSmoke,
                };
                Image img = FindImage(item.ImagePath);
                if (img != null)
                    pb.Image = img;
                else
                    pb.BackColor = Color.LightGray;

                Label lblName = new Label
                {
                    Text = item.Name,
                    Font = new Font("Noto Sans KR", 10f, FontStyle.Bold),
                    ForeColor = Color.MidnightBlue,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(cardW - 10, 24),
                    Location = new Point(5, 136)
                };

                Label lblPrice = new Label
                {
                    Text = item.Price.ToString("#,##0") + "원",
                    Font = new Font("Noto Sans KR", 9f),
                    ForeColor = Color.DimGray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(cardW - 10, 20),
                    Location = new Point(5, 158)
                };

                Button btnMinus = new Button
                {
                    Text = "−",
                    Size = new Size(34, 30),
                    Location = new Point(8, 186),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightGray,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 13f, FontStyle.Bold),
                    Tag = item
                };
                btnMinus.FlatAppearance.BorderSize = 0;

                Label lblQty = new Label
                {
                    Text = "0",
                    Size = new Size(75, 30),
                    Location = new Point(46, 186),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Noto Sans KR", 12f, FontStyle.Bold),
                    ForeColor = Color.MidnightBlue,
                    Tag = item
                };

                Button btnPlus = new Button
                {
                    Text = "+",
                    Size = new Size(34, 30),
                    Location = new Point(129, 186),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.BlueViolet,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 13f, FontStyle.Bold),
                    Tag = item
                };
                btnPlus.FlatAppearance.BorderSize = 0;

                btnPlus.Click += (s, ev) =>
                {
                    var m = (MenuItem)((Button)s).Tag;
                    m.Quantity++;
                    lblQty.Text = m.Quantity.ToString();
                    UpdateTotal();
                };

                btnMinus.Click += (s, ev) =>
                {
                    var m = (MenuItem)((Button)s).Tag;
                    if (m.Quantity > 0) { m.Quantity--; lblQty.Text = m.Quantity.ToString(); UpdateTotal(); }
                };

                card.Controls.AddRange(new Control[] { pb, lblName, lblPrice, btnMinus, lblQty, btnPlus });
                panelMenu.Controls.Add(card);

                col++;
                if (col >= 4) { col = 0; row++; }
            }
        }

        private void UpdateTotal()
        {
            int total = 0;
            foreach (var item in menuItems)
                total += item.Price * item.Quantity;

            lblTotal.Text = total.ToString("#,##0") + "원";
            btnOrder.Enabled = total > 0;
            btnOrder.BackColor = total > 0 ? Color.BlueViolet : Color.LightGray;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<string> orderLines = new List<string>();
            int total = 0;
            foreach (var item in menuItems)
            {
                if (item.Quantity > 0)
                {
                    orderLines.Add($"{item.Name} x{item.Quantity}  {(item.Price * item.Quantity).ToString("#,##0")}원");
                    total += item.Price * item.Quantity;
                }
            }
            Snack_Pay payForm = new Snack_Pay(orderLines, total);
            payForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}