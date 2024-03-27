namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(112, 97);
            label2.Name = "label2";
            label2.Size = new Size(237, 35);
            label2.TabIndex = 1;
            label2.Text = " Enter First Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(112, 168);
            label3.Name = "label3";
            label3.Size = new Size(274, 35);
            label3.TabIndex = 2;
            label3.Text = "Enter Second Number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(452, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 40);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowFrame;
            textBox2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(452, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 40);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(243, 241);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 5;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(452, 241);
            button2.Name = "button2";
            button2.Size = new Size(106, 42);
            button2.TabIndex = 6;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(255, 192, 128);
            radioButton1.Location = new Point(663, 97);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(36, 22);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "+";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(255, 192, 128);
            radioButton2.Location = new Point(663, 125);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(34, 22);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "-";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.FromArgb(255, 192, 128);
            radioButton3.Location = new Point(663, 153);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(36, 22);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "*";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.FromArgb(255, 192, 128);
            radioButton4.Location = new Point(663, 181);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(35, 22);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "/";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.ForeColor = Color.FromArgb(255, 192, 128);
            radioButton5.Location = new Point(663, 209);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(40, 22);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "%";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(291, 321);
            label4.Name = "label4";
            label4.Size = new Size(0, 35);
            label4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 422);
            Controls.Add(label4);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Label label4;
    }
}
