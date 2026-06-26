namespace Kiosk_Project
{
    partial class Snack_Order
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
            components = new System.ComponentModel.Container();
            timer1   = new System.Windows.Forms.Timer(components);
            lblDate  = new System.Windows.Forms.Label();
            lblTime  = new System.Windows.Forms.Label();
            panelMenu    = new System.Windows.Forms.Panel();
            panelBottom  = new System.Windows.Forms.Panel();
            lblTotalTitle = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            btnOrder = new System.Windows.Forms.Button();
            btnBack  = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            panelHeader = new System.Windows.Forms.Panel();

            panelBottom.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();

            // ── 폼 전체 ───────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Menu;
            ClientSize = new System.Drawing.Size(800, 975);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "매점";
            Load += Snack_Order_Load;

            // ── timer ─────────────────────────────────────────────
            timer1.Tick += timer1_Tick;

            // ── panelHeader (상단 헤더) ───────────────────────────
            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Location  = new System.Drawing.Point(0, 0);
            panelHeader.Size      = new System.Drawing.Size(800, 80);
            panelHeader.TabIndex  = 0;

            // 뒤로가기 버튼
            btnBack.Text      = "←  홈";
            btnBack.Font      = new System.Drawing.Font("Noto Sans KR", 11f, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.BlueViolet;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = System.Drawing.Color.Transparent;
            btnBack.Size      = new System.Drawing.Size(110, 40);
            btnBack.Location  = new System.Drawing.Point(10, 20);
            btnBack.TabIndex  = 1;
            btnBack.Click    += btnBack_Click;

            // 헤더 타이틀
            lblTitle.Text      = "🍿  매점";
            lblTitle.Font      = new System.Drawing.Font("Noto Sans KR", 20f, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            lblTitle.AutoSize  = true;
            lblTitle.Location  = new System.Drawing.Point(310, 22);
            lblTitle.TabIndex  = 2;

            // 날짜
            lblDate.AutoSize  = true;
            lblDate.Font      = new System.Drawing.Font("Malgun Gothic Semilight", 11f);
            lblDate.Location  = new System.Drawing.Point(560, 15);
            lblDate.TabIndex  = 3;
            lblDate.Text      = "날짜";

            // 시간
            lblTime.AutoSize  = true;
            lblTime.Font      = new System.Drawing.Font("Malgun Gothic", 15f, System.Drawing.FontStyle.Bold);
            lblTime.Location  = new System.Drawing.Point(570, 38);
            lblTime.TabIndex  = 4;
            lblTime.Text      = "시간";

            panelHeader.Controls.AddRange(new System.Windows.Forms.Control[]
                { btnBack, lblTitle, lblDate, lblTime });

            // ── panelMenu (메뉴 카드 영역, 스크롤 가능) ──────────
            panelMenu.BackColor   = System.Drawing.SystemColors.Menu;
            panelMenu.Location    = new System.Drawing.Point(0, 85);
            panelMenu.Size        = new System.Drawing.Size(800, 730);
            panelMenu.TabIndex    = 5;
            panelMenu.AutoScroll  = true;

            // ── panelBottom (하단 결제 바) ────────────────────────
            panelBottom.BackColor = System.Drawing.Color.White;
            panelBottom.Location  = new System.Drawing.Point(0, 820);
            panelBottom.Size      = new System.Drawing.Size(800, 155);
            panelBottom.TabIndex  = 6;

            lblTotalTitle.Text      = "총 결제 금액";
            lblTotalTitle.Font      = new System.Drawing.Font("Noto Sans KR", 12f);
            lblTotalTitle.ForeColor = System.Drawing.Color.DimGray;
            lblTotalTitle.AutoSize  = true;
            lblTotalTitle.Location  = new System.Drawing.Point(30, 25);
            lblTotalTitle.TabIndex  = 7;

            lblTotal.Text      = "0원";
            lblTotal.Font      = new System.Drawing.Font("Noto Sans KR", 22f, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.BlueViolet;
            lblTotal.AutoSize  = true;
            lblTotal.Location  = new System.Drawing.Point(30, 50);
            lblTotal.TabIndex  = 8;

            btnOrder.Text      = "주문하기";
            btnOrder.Font      = new System.Drawing.Font("Noto Sans KR", 15f, System.Drawing.FontStyle.Bold);
            btnOrder.ForeColor = System.Drawing.Color.White;
            btnOrder.BackColor = System.Drawing.Color.LightGray;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.Size      = new System.Drawing.Size(280, 60);
            btnOrder.Location  = new System.Drawing.Point(490, 48);
            btnOrder.TabIndex  = 9;
            btnOrder.Enabled   = false;
            btnOrder.Click    += btnOrder_Click;

            panelBottom.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblTotalTitle, lblTotal, btnOrder });

            // ── 폼에 컨트롤 추가 ──────────────────────────────────
            Controls.AddRange(new System.Windows.Forms.Control[]
                { panelHeader, panelMenu, panelBottom });

            panelBottom.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer  timer1;
        private System.Windows.Forms.Label  lblDate;
        private System.Windows.Forms.Label  lblTime;
        private System.Windows.Forms.Panel  panelMenu;
        private System.Windows.Forms.Panel  panelBottom;
        private System.Windows.Forms.Label  lblTotalTitle;
        private System.Windows.Forms.Label  lblTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label  lblTitle;
        private System.Windows.Forms.Panel  panelHeader;
    }
}
