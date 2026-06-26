namespace Kiosk_Project
{
    partial class NPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPay));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(278, 435);
            label1.Name = "label1";
            label1.Size = new Size(247, 15);
            label1.TabIndex = 1;
            label1.Text = "                                                            ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 435);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 1;
            label2.Text = "QR을 스캔하여 결제해주세요!!";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 501);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(801, 20);
            progressBar1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // NPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NPay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NPay";
            Load += NPay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}