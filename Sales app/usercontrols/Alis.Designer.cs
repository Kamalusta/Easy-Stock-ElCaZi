namespace Sales_app.usercontrols
{
    partial class Alis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alis));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label3 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            textBox6 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            textBox12 = new TextBox();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(740, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 59);
            label1.TabIndex = 0;
            label1.Text = "Alış";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 94);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Məhsul kodu";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(41, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(41, 162);
            listView1.Name = "listView1";
            listView1.Size = new Size(640, 324);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kodu";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ölkə";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Alış";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Satış";
            columnHeader6.Width = 100;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(685, 162);
            listView2.Name = "listView2";
            listView2.Size = new Size(555, 324);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Adı";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Əlaqə";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ünvan";
            columnHeader11.Width = 0;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Menecer";
            columnHeader12.Width = 0;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Kateqoriya";
            columnHeader13.Width = 0;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Borc";
            columnHeader14.Width = 120;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(925, 120);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 5;
            label3.Text = "Konturagentler";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(41, 547);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 31);
            textBox5.TabIndex = 43;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(685, 546);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 45;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(184, 518);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 40;
            label4.Text = "Qiymət";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(187, 547);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 31);
            textBox3.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(576, 540);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 39;
            button1.Text = "Əlavə et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(332, 519);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 41;
            label5.Text = "Miqdar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 518);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 44;
            label6.Text = "Məhsul ID";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(331, 547);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 31);
            textBox4.TabIndex = 38;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1089, 545);
            dateTimePicker1.Margin = new Padding(3, 1, 1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 34);
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.Value = new DateTime(2024, 4, 10, 17, 51, 3, 0);
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(1089, 664);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 51);
            textBox7.TabIndex = 51;
            textBox7.Text = "0.00";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(693, 543);
            label9.Name = "label9";
            label9.Size = new Size(160, 38);
            label9.TabIndex = 49;
            label9.Text = "Seçilməyib";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1158, 636);
            label11.Name = "label11";
            label11.Size = new Size(75, 25);
            label11.TabIndex = 52;
            label11.Text = "Ödəniş";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(849, 641);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 48;
            label8.Text = "Ümumi Məbləğ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(869, 670);
            label7.Name = "label7";
            label7.Size = new Size(86, 45);
            label7.TabIndex = 47;
            label7.Text = "0.00";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(614, 554);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 50;
            label10.Text = "Müştəri :";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(949, 762);
            button3.Name = "button3";
            button3.Size = new Size(237, 55);
            button3.TabIndex = 53;
            button3.Text = "Mədaxil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(41, 590);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(806, 226);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.KeyUp += dataGridView1_KeyUp;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(920, 819);
            label22.Name = "label22";
            label22.Size = new Size(27, 29);
            label22.TabIndex = 58;
            label22.Text = "0";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(653, 819);
            label21.Name = "label21";
            label21.Size = new Size(27, 29);
            label21.TabIndex = 57;
            label21.Text = "0";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(518, 819);
            label20.Name = "label20";
            label20.Size = new Size(144, 25);
            label20.TabIndex = 56;
            label20.Text = "Ümumi Miqdar:";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(777, 819);
            label19.Name = "label19";
            label19.Size = new Size(149, 25);
            label19.TabIndex = 55;
            label19.Text = "Ümumi Məbləğ:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBox9);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(textBox11);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(textBox12);
            panel4.Controls.Add(label18);
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(536, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 281);
            panel4.TabIndex = 59;
            panel4.Visible = false;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(379, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(148, 234);
            button4.Name = "button4";
            button4.Size = new Size(155, 39);
            button4.TabIndex = 53;
            button4.Text = "Əlavə Et";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(88, 203);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 27);
            textBox6.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(7, 206);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 49;
            label12.Text = "Miqdar :";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(88, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(300, 27);
            textBox8.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(7, 173);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 48;
            label14.Text = "Satış :";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(88, 137);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(300, 27);
            textBox9.TabIndex = 45;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(7, 140);
            label15.Name = "label15";
            label15.Size = new Size(43, 20);
            label15.TabIndex = 50;
            label15.Text = "Alış :";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(88, 104);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(300, 27);
            textBox10.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(7, 104);
            label16.Name = "label16";
            label16.Size = new Size(48, 20);
            label16.TabIndex = 51;
            label16.Text = "Ölkə :";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(88, 71);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(300, 27);
            textBox11.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(7, 74);
            label17.Name = "label17";
            label17.Size = new Size(54, 20);
            label17.TabIndex = 52;
            label17.Text = "Kodu :";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(88, 39);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(300, 27);
            textBox12.TabIndex = 42;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(7, 41);
            label18.Name = "label18";
            label18.Size = new Size(84, 20);
            label18.TabIndex = 41;
            label18.Text = "Malın Adı :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Alis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Alis";
            Size = new Size(1282, 850);
            Load += Alis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listView2;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label3;
        private TextBox textBox5;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private Label label9;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label10;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button button4;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox8;
        private Label label14;
        private TextBox textBox9;
        private Label label15;
        private TextBox textBox10;
        private Label label16;
        private TextBox textBox11;
        private Label label17;
        private TextBox textBox12;
        private Label label18;
        private PictureBox pictureBox1;
    }
}
