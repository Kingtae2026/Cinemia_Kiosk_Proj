namespace Kiosk_Project
{
    partial class Snack_Pay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            txtOrderSummary = new System.Windows.Forms.TextBox();
            lblTotalCaption = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblPayTitle = new System.Windows.Forms.Label();
            picCard = new System.Windows.Forms.PictureBox();
            lblCard = new System.Windows.Forms.Label();
            picNPay = new System.Windows.Forms.PictureBox();
            lblNPay = new System.Windows.Forms.Label();
            picKakao = new System.Windows.Forms.PictureBox();
            lblKakao = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNPay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKakao).BeginInit();
            SuspendLayout();

            // ── 폼 ───────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Menu;
            ClientSize = new System.Drawing.Size(800, 975);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "매점 결제";
            Load += Snack_Pay_Load;

            // ── 타이틀 ───────────────────────────────────────────
            lblTitle.Text = "주문 확인 및 결제";
            lblTitle.Font = new System.Drawing.Font("Noto Sans KR", 22f, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(20, 20);

            lblSubtitle.Text = "아래 내역을 확인하고 결제 수단을 선택하세요.";
            lblSubtitle.Font = new System.Drawing.Font("Noto Sans KR", 10f);
            lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new System.Drawing.Point(24, 72);

            // ── 주문 내역 ─────────────────────────────────────────
            txtOrderSummary.BackColor = System.Drawing.Color.White;
            txtOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtOrderSummary.Font = new System.Drawing.Font("Noto Sans KR", 12f);
            txtOrderSummary.ForeColor = System.Drawing.Color.MidnightBlue;
            txtOrderSummary.Location = new System.Drawing.Point(30, 110);
            txtOrderSummary.Multiline = true;
            txtOrderSummary.ReadOnly = true;
            txtOrderSummary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtOrderSummary.Size = new System.Drawing.Size(740, 200);

            // ── 총액 ─────────────────────────────────────────────
            lblTotalCaption.Text = "최종 결제금액";
            lblTotalCaption.Font = new System.Drawing.Font("Noto Sans KR", 13f);
            lblTotalCaption.ForeColor = System.Drawing.Color.DimGray;
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Location = new System.Drawing.Point(30, 335);

            lblTotal.Text = "0원";
            lblTotal.Font = new System.Drawing.Font("Noto Sans KR", 26f, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.BlueViolet;
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(30, 365);

            // ── 결제수단 타이틀 ───────────────────────────────────
            lblPayTitle.Text = "결제 수단 선택";
            lblPayTitle.Font = new System.Drawing.Font("Noto Sans KR", 14f, System.Drawing.FontStyle.Bold);
            lblPayTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            lblPayTitle.AutoSize = true;
            lblPayTitle.Location = new System.Drawing.Point(30, 450);

            // ── 카드 PictureBox (클릭 이벤트 직접 연결) ──────────
            picCard.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picCard.Location = new System.Drawing.Point(55, 500);
            picCard.Size = new System.Drawing.Size(202, 180);
            picCard.TabStop = false;
            picCard.Cursor = System.Windows.Forms.Cursors.Hand;
            picCard.Click += picCard_Click;

            lblCard.Text = "카드 결제";
            lblCard.Font = new System.Drawing.Font("Noto Sans KR", 12f, System.Drawing.FontStyle.Bold);
            lblCard.ForeColor = System.Drawing.Color.DimGray;
            lblCard.AutoSize = true;
            lblCard.Location = new System.Drawing.Point(105, 690);

            // ── 네이버페이 PictureBox ─────────────────────────────
            picNPay.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            picNPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picNPay.Location = new System.Drawing.Point(298, 500);
            picNPay.Size = new System.Drawing.Size(202, 180);
            picNPay.TabStop = false;
            picNPay.Cursor = System.Windows.Forms.Cursors.Hand;
            picNPay.Click += picNPay_Click;

            lblNPay.Text = "네이버페이";
            lblNPay.Font = new System.Drawing.Font("Noto Sans KR", 12f, System.Drawing.FontStyle.Bold);
            lblNPay.ForeColor = System.Drawing.Color.DimGray;
            lblNPay.AutoSize = true;
            lblNPay.Location = new System.Drawing.Point(340, 690);

            // ── 카카오페이 PictureBox ─────────────────────────────
            picKakao.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            picKakao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picKakao.Location = new System.Drawing.Point(540, 500);
            picKakao.Size = new System.Drawing.Size(202, 180);
            picKakao.TabStop = false;
            picKakao.Cursor = System.Windows.Forms.Cursors.Hand;
            picKakao.Click += picKakao_Click;

            lblKakao.Text = "카카오페이";
            lblKakao.Font = new System.Drawing.Font("Noto Sans KR", 12f, System.Drawing.FontStyle.Bold);
            lblKakao.ForeColor = System.Drawing.Color.DimGray;
            lblKakao.AutoSize = true;
            lblKakao.Location = new System.Drawing.Point(575, 690);

            // ── 뒤로가기 ─────────────────────────────────────────
            btnBack.Text = "← 뒤로";
            btnBack.Font = new System.Drawing.Font("Noto Sans KR", 11f, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.BlueViolet;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = System.Drawing.Color.Transparent;
            btnBack.Size = new System.Drawing.Size(100, 36);
            btnBack.Location = new System.Drawing.Point(670, 20);
            btnBack.Click += btnBack_Click;

            // ── 컨트롤 추가 ───────────────────────────────────────
            Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblSubtitle,
                txtOrderSummary,
                lblTotalCaption, lblTotal,
                lblPayTitle,
                picCard,  lblCard,
                picNPay,  lblNPay,
                picKakao, lblKakao,
                btnBack
            });

            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNPay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKakao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtOrderSummary;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPayTitle;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.PictureBox picNPay;
        private System.Windows.Forms.Label lblNPay;
        private System.Windows.Forms.PictureBox picKakao;
        private System.Windows.Forms.Label lblKakao;
        private System.Windows.Forms.Button btnBack;
    }
}