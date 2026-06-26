namespace Kiosk_Project
{
    partial class Card_Inner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card_Inner));
            Card = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)Card).BeginInit();
            SuspendLayout();
            // 
            // Card
            // 
            Card.Image = (Image)resources.GetObject("Card.Image");
            Card.Location = new Point(12, 4);
            Card.Name = "Card";
            Card.Size = new Size(786, 440);
            Card.SizeMode = PictureBoxSizeMode.StretchImage;
            Card.TabIndex = 0;
            Card.TabStop = false;
            Card.Click += Card_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-5, 425);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(816, 19);
            progressBar1.TabIndex = 1;
            // 
            // Card_Inner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(progressBar1);
            Controls.Add(Card);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Card_Inner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card_Inner";
            Load += Card_Inner_Load;
            ((System.ComponentModel.ISupportInitialize)Card).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Card;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}