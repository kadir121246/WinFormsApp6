namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(53, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(641, 93);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "ÜYE SEÇ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // button3
            // 
            button3.Location = new Point(489, 263);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 2;
            button3.Text = "PLAN LİSTELE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.Location = new Point(28, 390);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "HESAPLA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(251, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(431, 46);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(489, 292);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(278, 139);
            listBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(626, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(489, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 325);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 11;
            label1.Text = "ÜYE GİRİŞİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 27);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 12;
            label2.Text = "STANDART ÜYELER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 27);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 13;
            label3.Text = "VIP ÜYELER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 213);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 14;
            label4.Text = "SPOR PLANLA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 307);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 15;
            label5.Text = "FİYAT";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 365);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "İNDİRİM";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
    }
}
