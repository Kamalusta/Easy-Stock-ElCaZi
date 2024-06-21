namespace Sales_app.usercontrols
{
    partial class HesabatMusteri
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label14 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(607, 0);
            label1.Name = "label1";
            label1.Size = new Size(401, 59);
            label1.TabIndex = 2;
            label1.Text = " Hesabat (Müştəri)";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(20, 263);
            listView1.Name = "listView1";
            listView1.Size = new Size(906, 496);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 180);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 5;
            label2.Text = "Müştəri:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(2, 16);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 6;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(125, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 34);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.ForeColor = Color.Black;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.Location = new Point(883, 263);
            listView2.Name = "listView2";
            listView2.Size = new Size(728, 496);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.Width = 80;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(201, 16);
            dateTimePicker1.Margin = new Padding(3, 1, 1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 34);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2024, 4, 10, 17, 50, 22, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(201, 70);
            dateTimePicker2.Margin = new Padding(3, 1, 1, 1);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(153, 34);
            dateTimePicker2.TabIndex = 10;
            dateTimePicker2.Value = new DateTime(2024, 4, 10, 17, 50, 22, 0);
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 75);
            button2.Name = "button2";
            button2.Size = new Size(124, 38);
            button2.TabIndex = 11;
            button2.Text = "Təmizlə";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(449, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 131);
            panel1.TabIndex = 12;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(183, 798);
            label12.Name = "label12";
            label12.Size = new Size(23, 25);
            label12.TabIndex = 29;
            label12.Text = "0";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(17, 798);
            label11.Name = "label11";
            label11.Size = new Size(23, 25);
            label11.TabIndex = 28;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(375, 768);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 27;
            label10.Text = "Miqdar:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 768);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 26;
            label9.Text = "Məbləğ:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(180, 768);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 25;
            label7.Text = "Ödədi:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(377, 798);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 24;
            label8.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(762, 768);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 23;
            label6.Text = "Borc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(762, 798);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 22;
            label5.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(565, 768);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 31;
            label3.Text = "Köhnə Borc:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(565, 798);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 30;
            label4.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(125, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 34);
            textBox2.TabIndex = 33;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(30, 227);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 32;
            label13.Text = "Menecer:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(357, 229);
            button3.Name = "button3";
            button3.Size = new Size(64, 29);
            button3.TabIndex = 39;
            button3.Text = "Borc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(832, 226);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 40;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1517, 229);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 41;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1217, 205);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 42;
            label14.Text = "Müştəri";
            // 
            // HesabatMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label14);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(listView2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "HesabatMusteri";
            Size = new Size(1641, 825);
            Load += HesabatMusteri_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label13;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label14;
    }
}
