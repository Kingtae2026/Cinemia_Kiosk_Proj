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
    public partial class NPay : Form
    {
        public NPay()
        {
            InitializeComponent();
        }

        private void NPay_Load(object sender, EventArgs e)
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
                MessageBox.Show("QR을 인식하지 못하였습니다!! 잠시 후 다시 시도해 주세요!!", "결제 오류!!");
                progressBar1.Value = 0;
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picturebox1 를 클릭하면 QR을 스캔하는 행동으로 인식
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("결제가 완료되었습니다!", "결제 성공!!");
            this.Close();
        }
    }
}
