namespace Kiosk_Project
{
    partial class Login
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
            timer1 = new System.Windows.Forms.Timer(components);
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.BlueViolet;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Noto Sans KR", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(356, 68);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(38, 47);
            textBox6.TabIndex = 18;
            textBox6.Text = "X";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.BlueViolet;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Noto Sans KR", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(312, 68);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(38, 47);
            textBox5.TabIndex = 19;
            textBox5.Text = "O";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BlueViolet;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Noto Sans KR", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(268, 68);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(38, 47);
            textBox4.TabIndex = 20;
            textBox4.Text = "B";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BlueViolet;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Noto Sans KR", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(224, 68);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 47);
            textBox3.TabIndex = 21;
            textBox3.Text = "T";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BlueViolet;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Noto Sans KR", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(180, 68);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 47);
            textBox2.TabIndex = 22;
            textBox2.Text = "G";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.FlatAppearance.BorderColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ScrollBar;
            button1.Location = new Point(525, 1);
            button1.Name = "button1";
            button1.Size = new Size(95, 71);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(94, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 34);
            textBox1.TabIndex = 24;
            textBox1.Text = " 아이디";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(94, 204);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '*';
            textBox7.Size = new Size(358, 34);
            textBox7.TabIndex = 24;
            textBox7.Text = "비밀번호";
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(467, 155);
            button2.Name = "button2";
            button2.Size = new Size(88, 83);
            button2.TabIndex = 25;
            button2.Text = "로그인";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "비밀번호 표시";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(621, 374);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox7;
        private Button button2;
        private CheckBox checkBox1;
    }
}