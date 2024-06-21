namespace Sales_app.usercontrols
{
    partial class Emeliyyat
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emeliyyat));
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dəyişToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            listView2 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            panel2 = new Panel();
            button9 = new Button();
            button8 = new Button();
            listBox1 = new ListBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label17 = new Label();
            label16 = new Label();
            label12 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            button10 = new Button();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(737, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 59);
            label1.TabIndex = 0;
            label1.Text = "Əməliyyatlar";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 289);
            listView1.Name = "listView1";
            listView1.Size = new Size(738, 580);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Qaimə id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Məbləğ";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ödənib";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tarix";
            columnHeader5.Width = 120;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { dəyişToolStripMenuItem, silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 92);
            //contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // dəyişToolStripMenuItem
            // 
            dəyişToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dəyişToolStripMenuItem.Name = "dəyişToolStripMenuItem";
            dəyişToolStripMenuItem.Size = new Size(210, 30);
            dəyişToolStripMenuItem.Text = "Dəyiş";
            dəyişToolStripMenuItem.Click += dəyişToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(210, 30);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1113, 243);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 2;
            label2.Text = "Qaimə id:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1223, 243);
            label3.Name = "label3";
            label3.Size = new Size(27, 31);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // listView2
            // 
            listView2.Activation = ItemActivation.OneClick;
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.LabelEdit = true;
            listView2.Location = new Point(795, 289);
            listView2.Name = "listView2";
            listView2.Size = new Size(719, 580);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ad";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kod";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ölkə";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Miqdar";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Qiymət";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Məbləğ";
            columnHeader11.Width = 120;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 67);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 6;
            button1.Text = "Məxaric";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(179, 67);
            button2.Name = "button2";
            button2.Size = new Size(135, 41);
            button2.TabIndex = 7;
            button2.Text = "Mədaxil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(547, 182);
            label4.Name = "label4";
            label4.Size = new Size(293, 45);
            label4.TabIndex = 8;
            label4.Text = "Məxaric Qaimələr";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(319, 67);
            button3.Name = "button3";
            button3.Size = new Size(135, 41);
            button3.TabIndex = 9;
            button3.Text = "Kassa Mədaxil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(656, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 216);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkRed;
            button6.Location = new Point(167, 146);
            button6.Name = "button6";
            button6.Size = new Size(56, 38);
            button6.TabIndex = 11;
            button6.Text = "Sil";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(94, 146);
            button7.Name = "button7";
            button7.Size = new Size(117, 38);
            button7.TabIndex = 12;
            button7.Text = "Əlavə Et";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(229, 146);
            button5.Name = "button5";
            button5.Size = new Size(52, 38);
            button5.TabIndex = 10;
            button5.Text = "Çıxış";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(44, 146);
            button4.Name = "button4";
            button4.Size = new Size(117, 38);
            button4.TabIndex = 9;
            button4.Text = "Dəyiş";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 95);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 8;
            label9.Text = "Qiymət :";
            // 
            // textBox5
            // 
            textBox5.ImeMode = ImeMode.NoControl;
            textBox5.Location = new Point(81, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 27);
            textBox5.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 54);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 5;
            label8.Text = "Miqdar :";
            // 
            // textBox4
            // 
            textBox4.ImeMode = ImeMode.NoControl;
            textBox4.Location = new Point(81, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 13);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 2;
            label6.Text = "Kod :";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(81, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 253);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 1;
            label5.Text = "Müştəri ad :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(153, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(842, 815);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(1247, 872);
            label22.Name = "label22";
            label22.Size = new Size(27, 29);
            label22.TabIndex = 52;
            label22.Text = "0";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(1000, 872);
            label21.Name = "label21";
            label21.Size = new Size(27, 29);
            label21.TabIndex = 51;
            label21.Text = "0";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(874, 875);
            label20.Name = "label20";
            label20.Size = new Size(129, 22);
            label20.TabIndex = 50;
            label20.Text = "Ümumi Miqdar:";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1114, 875);
            label19.Name = "label19";
            label19.Size = new Size(133, 22);
            label19.TabIndex = 49;
            label19.Text = "Ümumi Məbləğ:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(339, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 560);
            panel2.TabIndex = 53;
            panel2.Visible = false;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(342, 519);
            button9.Name = "button9";
            button9.Size = new Size(127, 38);
            button9.TabIndex = 20;
            button9.Text = " İmtina et";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(135, 519);
            button8.Name = "button8";
            button8.Size = new Size(127, 38);
            button8.TabIndex = 19;
            button8.Text = "  Saxla";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(316, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 18;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(121, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 27);
            textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(121, 137);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 27);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(121, 59);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 27);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.Enter += textBox6_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(121, 95);
            dateTimePicker1.Margin = new Padding(3, 1, 1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 34);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2024, 4, 10, 19, 27, 49, 0);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(11, 170);
            label17.Name = "label17";
            label17.Size = new Size(98, 31);
            label17.TabIndex = 9;
            label17.Text = "Ödəndi:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(9, 130);
            label16.Name = "label16";
            label16.Size = new Size(101, 31);
            label16.TabIndex = 8;
            label16.Text = "Məbləğ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(9, 95);
            label12.Name = "label12";
            label12.Size = new Size(72, 31);
            label12.TabIndex = 7;
            label12.Text = "Tarix:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(9, 55);
            label15.Name = "label15";
            label15.Size = new Size(103, 31);
            label15.TabIndex = 5;
            label15.Text = "Müştəri:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(297, 12);
            label14.Name = "label14";
            label14.Size = new Size(27, 31);
            label14.TabIndex = 4;
            label14.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(182, 11);
            label13.Name = "label13";
            label13.Size = new Size(116, 31);
            label13.TabIndex = 3;
            label13.Text = "Qaimə id:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(539, 309);
            dataGridView1.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLight;
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(459, 67);
            button10.Name = "button10";
            button10.Size = new Size(135, 41);
            button10.TabIndex = 54;
            button10.Text = "Geri Qayıdan";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Emeliyyat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(button10);
            Controls.Add(panel2);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Emeliyyat";
            Size = new Size(1540, 903);
            Load += Emeliyyat_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
        private Label label3;
        private ListView listView2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label16;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private ListBox listBox1;
        private Button button8;
        private Button button9;
        private ColumnHeader columnHeader11;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dəyişToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private Button button10;
    }
}
