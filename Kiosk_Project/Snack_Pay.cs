using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Kiosk_Project
{
    public partial class Snack_Pay : Form
    {
        private List<string> orderLines;
        private int total;

        public Snack_Pay(List<string> orderLines, int total)
        {
            InitializeComponent();
            this.orderLines = orderLines;
            this.total = total;
        }

        private void Snack_Pay_Load(object sender, EventArgs e)
        {
            txtOrderSummary.Clear();
            foreach (var line in orderLines)
                txtOrderSummary.AppendText(line + "\r\n");
            txtOrderSummary.AppendText("─────────────────────────\r\n");
            txtOrderSummary.AppendText($"합계  {total.ToString("#,##0")}원");

            lblTotal.Text = total.ToString("#,##0") + "원";

            // resx에 내장된 이미지를 가져옴 (Ticket_Pay와 동일한 방식)
            var res = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Pay));
            try { picCard.Image = (Image)res.GetObject("pictureBox1.Image"); } catch { }
            try { picNPay.Image = (Image)res.GetObject("pictureBox2.Image"); } catch { }
            try { picKakao.Image = (Image)res.GetObject("pictureBox3.Image"); } catch { }
        }

        // ── 카드 결제 ─────────────────────────────────────────────
        private void picCard_Click(object sender, EventArgs e)
        {
            Card_Inner card = new Card_Inner();
            if (card.ShowDialog() == DialogResult.OK)
                ShowComplete();
        }

        // ── 네이버페이 ────────────────────────────────────────────
        private void picNPay_Click(object sender, EventArgs e)
        {
            NPay nPay = new NPay();
            if (nPay.ShowDialog() == DialogResult.OK)
                ShowComplete();
        }

        // ── 카카오페이 ───────────────────────────────────────────
        private void picKakao_Click(object sender, EventArgs e)
        {
            KaKao kao = new KaKao();
            if (kao.ShowDialog() == DialogResult.OK)
                ShowComplete();
        }

        // ── 결제 완료 처리 ────────────────────────────────────────
        private void ShowComplete()
        {
            MessageBox.Show(
                "결제가 완료되었습니다!\n잠시 후 매점에서 수령해 주세요. 🍿",
                "결제 완료",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Application.Restart();
        }

        // ── 뒤로가기 ─────────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}