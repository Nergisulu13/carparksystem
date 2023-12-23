namespace carparksystem
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox4 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(42, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Ve Saat Seçimi";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Location = new Point(438, 279);
            button1.Name = "button1";
            button1.Size = new Size(113, 53);
            button1.TabIndex = 9;
            button1.Text = "Tamamla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 341);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(525, 75);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(341, 165);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Öğrenci İndirimi";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.RosyBrown;
            checkBox1.Location = new Point(92, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 27);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Ögrenci İndirimi";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 30);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(26, 54);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 7;
            label2.Text = "TC Numarası";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Location = new Point(295, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 201);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Saatler";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.WhiteSmoke;
            radioButton6.Location = new Point(46, 138);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(128, 27);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "10 Saat Üzeri";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.WhiteSmoke;
            radioButton5.Location = new Point(46, 87);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(100, 27);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "5-10 Saat";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.WhiteSmoke;
            radioButton4.Location = new Point(48, 38);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(91, 27);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "1-5 Saat";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(46, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 201);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araçlar";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.WhiteSmoke;
            radioButton3.Location = new Point(33, 127);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(107, 27);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ticari Araç";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.WhiteSmoke;
            radioButton1.Location = new Point(33, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Binek Araç";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.WhiteSmoke;
            radioButton2.Location = new Point(33, 87);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "SUV Araç";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}