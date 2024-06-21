namespace Sales_app.usercontrols
{
    partial class Hesabatlar
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
            panel1 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            label13 = new Label();
            label14 = new Label();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(531, 2);
            label1.Name = "label1";
            label1.Size = new Size(381, 59);
            label1.TabIndex = 0;
            label1.Text = "Hesabat (Məhsul)";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 64);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(29, 237);
            listView1.Name = "listView1";
            listView1.Size = new Size(982, 534);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 80;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(759, 190);
            button1.Name = "button1";
            button1.Size = new Size(153, 38);
            button1.TabIndex = 3;
            button1.Text = "Anbar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 34);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(213, 45);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(152, 34);
            dateTimePicker2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(6, 98);
            button2.Name = "button2";
            button2.Size = new Size(151, 44);
            button2.TabIndex = 7;
            button2.Text = "Hesabla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(33, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 30);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(181, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 30);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(329, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 30);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 165);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 11;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 165);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 12;
            label3.Text = "Kod";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(329, 165);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 13;
            label4.Text = "Ölkə";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(705, 807);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 14;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(705, 777);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 15;
            label6.Text = "Qalıq miqdar:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(477, 777);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 17;
            label7.Text = "Satış məbləği:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(477, 807);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 16;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(28, 777);
            label9.Name = "label9";
            label9.Size = new Size(119, 25);
            label9.TabIndex = 18;
            label9.Text = " Alış miqdar:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(247, 777);
            label10.Name = "label10";
            label10.Size = new Size(126, 25);
            label10.TabIndex = 19;
            label10.Text = "Satış miqdar:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(36, 807);
            label11.Name = "label11";
            label11.Size = new Size(23, 25);
            label11.TabIndex = 20;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(247, 807);
            label12.Name = "label12";
            label12.Size = new Size(23, 25);
            label12.TabIndex = 21;
            label12.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(1183, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 154);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış Analizi";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(477, 194);
            button3.Name = "button3";
            button3.Size = new Size(90, 34);
            button3.TabIndex = 23;
            button3.Text = "Təmizlə";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(915, 777);
            label13.Name = "label13";
            label13.Size = new Size(133, 25);
            label13.TabIndex = 25;
            label13.Text = "Qalıq məbləğ:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(915, 807);
            label14.Name = "label14";
            label14.Size = new Size(23, 25);
            label14.TabIndex = 24;
            label14.Text = "0";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.Location = new Point(948, 237);
            listView2.Name = "listView2";
            listView2.Size = new Size(606, 534);
            listView2.TabIndex = 26;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.Width = 80;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1484, 777);
            label15.Name = "label15";
            label15.Size = new Size(62, 25);
            label15.TabIndex = 32;
            label15.Text = "Satış:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1484, 807);
            label16.Name = "label16";
            label16.Size = new Size(23, 25);
            label16.TabIndex = 31;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(1214, 777);
            label17.Name = "label17";
            label17.Size = new Size(60, 25);
            label17.TabIndex = 30;
            label17.Text = "Alınıb";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1214, 807);
            label18.Name = "label18";
            label18.Size = new Size(23, 25);
            label18.TabIndex = 29;
            label18.Text = "0";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1335, 777);
            label19.Name = "label19";
            label19.Size = new Size(100, 25);
            label19.TabIndex = 28;
            label19.Text = "Qaytarılıb:";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1373, 807);
            label20.Name = "label20";
            label20.Size = new Size(23, 25);
            label20.TabIndex = 27;
            label20.Text = "0";
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(918, 199);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 38;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Hesabatlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(button5);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(listView2);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Hesabatlar";
            Size = new Size(1575, 835);
            Load += Hesabatlar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
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
        private GroupBox groupBox1;
        private Button button3;
        private Label label13;
        private Label label14;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button button5;
    }
}
