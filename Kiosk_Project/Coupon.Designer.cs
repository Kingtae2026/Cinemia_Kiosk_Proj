namespace Kiosk_Project
{
    partial class Coupon
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
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 79);
            textBox1.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.BlueViolet;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Noto Sans KR", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(130, 23);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(25, 33);
            textBox6.TabIndex = 28;
            textBox6.Text = "X";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.BlueViolet;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Noto Sans KR", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(101, 23);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(25, 33);
            textBox5.TabIndex = 29;
            textBox5.Text = "O";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BlueViolet;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Noto Sans KR", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(72, 23);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(25, 33);
            textBox4.TabIndex = 30;
            textBox4.Text = "B";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BlueViolet;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Noto Sans KR", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(43, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(25, 33);
            textBox3.TabIndex = 31;
            textBox3.Text = "T";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BlueViolet;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Noto Sans KR", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(14, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 33);
            textBox2.TabIndex = 32;
            textBox2.Text = "G";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(440, 12);
            button1.Name = "button1";
            button1.Size = new Size(51, 44);
            button1.TabIndex = 33;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 146);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 34;
            label1.Text = "쿠폰 코드 입력";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(101, 196);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 23);
            textBox7.TabIndex = 35;
            // 
            // Coupon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 327);
            Controls.Add(textBox7);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Coupon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coupon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox7;
    }
}