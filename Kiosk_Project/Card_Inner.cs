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
    public partial class Card_Inner : Form
    {
        public Card_Inner()
        {
            InitializeComponent();
        }

        private void Card_Inner_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("카드를 인식하지 못하였습니다!! 잠시 후 다시 시도해 주세요!!", "결제 오류!!");
                progressBar1.Value = 0;
                this.Close();
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            //Card 를 클릭하면 카드를 넣는 행동으로 인식
            timer1.Stop();
            MessageBox.Show("결제가 완료되었습니다!", "결제 성공!!");
            this.DialogResult = DialogResult.OK;
            this.Close();
            //MessageBox.Show("영수증 출력하시겠습니까 ? ");
        }
    }
}
