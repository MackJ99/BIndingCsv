namespace BIndingCsv
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
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1175, 263);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "EID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(481, 536);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(626, 536);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(572, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Job Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(813, 9);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 67);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 9;
            label5.Text = "Business Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 67);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(535, 67);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 11;
            label7.Text = "Ethnicity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(784, 67);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 12;
            label8.Text = "Age";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 133);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 13;
            label9.Text = "Hire Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 133);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 14;
            label10.Text = "Annual Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(542, 133);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 15;
            label11.Text = "Bonus %";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(788, 133);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 16;
            label12.Text = "Country";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 189);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 17;
            label13.Text = "City";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(626, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(889, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(181, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(337, 59);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(181, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(594, 59);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(181, 23);
            textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(818, 59);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(181, 23);
            textBox8.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(74, 125);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(181, 23);
            textBox9.TabIndex = 24;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(355, 125);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(181, 23);
            textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(601, 125);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(181, 23);
            textBox11.TabIndex = 26;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(844, 125);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(181, 23);
            textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(46, 181);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(181, 23);
            textBox13.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 571);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
    }
}