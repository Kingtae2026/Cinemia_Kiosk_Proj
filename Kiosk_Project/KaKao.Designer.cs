namespace Kiosk_Project
{
    partial class KaKao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaKao));
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 508);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(801, 23);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 454);
            label1.Name = "label1";
            label1.Size = new Size(436, 39);
            label1.TabIndex = 2;
            label1.Text = "카카오페이 앱을 열어 결제해주세요!!";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // KaKao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KaKao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KaKao";
            Load += KaKao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}