namespace carparksystem
{
    partial class Form3
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Ücret";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(224, 188);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 7;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 30);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 30);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 30);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 214);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 2;
            label3.Text = "10 Saat Üzeri Ücret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(32, 97);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 1;
            label2.Text = "5-10 Saat Arası Ücret";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 62);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 0;
            label1.Text = "1-5 Saat Arası Ücret";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(458, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 364);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gün Seçimi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 31);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 214);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(189, 55);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 4;
            label5.Text = "Gün Seçiniz";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 496);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
    }
}