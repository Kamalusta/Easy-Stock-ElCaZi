namespace Sales_app.usercontrols
{
    partial class Musteriler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            button6 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(638, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 59);
            label1.TabIndex = 1;
            label1.Text = "Müştərilər";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(561, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(953, 693);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İd";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Əlaqə nöm.";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ünvan";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Menecer";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kateqoriya";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Köhnə borc";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Borc";
            columnHeader8.Width = 100;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(453, 330);
            button5.Name = "button5";
            button5.Size = new Size(102, 40);
            button5.TabIndex = 8;
            button5.Text = "Təmizlə";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(162, 330);
            button4.Name = "button4";
            button4.Size = new Size(186, 40);
            button4.TabIndex = 7;
            button4.Text = "Axtar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(482, 424);
            button3.Name = "button3";
            button3.Size = new Size(73, 42);
            button3.TabIndex = 59;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(372, 424);
            button2.Name = "button2";
            button2.Size = new Size(102, 42);
            button2.TabIndex = 10;
            button2.Text = "Dəyiş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(162, 424);
            button1.Name = "button1";
            button1.Size = new Size(204, 42);
            button1.TabIndex = 9;
            button1.Text = "Əlavə Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(162, 290);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(393, 31);
            textBox6.TabIndex = 6;
            textBox6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 290);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 54;
            label7.Text = "Borc :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(162, 257);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(393, 31);
            textBox5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 257);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 53;
            label6.Text = "Kateqoriya :";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(162, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 31);
            textBox4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 224);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 55;
            label5.Text = "Menecer :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(162, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(393, 31);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 191);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 56;
            label4.Text = "Ünvan :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(162, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 31);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 158);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 57;
            label3.Text = "Əlaqə nöm.:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(162, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 125);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 45;
            label2.Text = "Ad Soyad :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(163, 83);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 33);
            radioButton1.TabIndex = 60;
            radioButton1.TabStop = true;
            radioButton1.Text = "Müştəri";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(403, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(175, 33);
            radioButton2.TabIndex = 61;
            radioButton2.Text = "Konturagent";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(26, 487);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 331);
            panel1.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(373, 95);
            dateTimePicker1.Margin = new Padding(3, 1, 1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 34);
            dateTimePicker1.TabIndex = 63;
            dateTimePicker1.Value = new DateTime(2024, 4, 10, 17, 50, 38, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(105, 91);
            label11.Name = "label11";
            label11.Size = new Size(130, 31);
            label11.TabIndex = 58;
            label11.Text = "Seçilməyib";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 95);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 57;
            label10.Text = "Müştəri :";
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(158, 229);
            button6.Name = "button6";
            button6.Size = new Size(170, 42);
            button6.TabIndex = 56;
            button6.Text = "KASSA";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 146);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 55;
            label9.Text = "Məbləğ :";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(108, 134);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 51);
            textBox7.TabIndex = 47;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(158, 0);
            label8.Name = "label8";
            label8.Size = new Size(218, 41);
            label8.TabIndex = 46;
            label8.Text = "Kassa Mədaxil";
            // 
            // Musteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Musteriler";
            Size = new Size(1540, 830);
            Load += Musteriler_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Button button6;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private ColumnHeader columnHeader8;
        private DateTimePicker dateTimePicker1;
    }
}
