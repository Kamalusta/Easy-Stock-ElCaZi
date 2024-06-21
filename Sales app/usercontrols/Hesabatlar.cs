using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Sales_app.usercontrols
{
    public partial class Hesabatlar : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private DataTable dataTable;
        public Hesabatlar(SqlConnection conn)
        {
            InitializeComponent();
            //InitializeDatabase();
            con = conn;

        }

        public void InitializeDatabase()
        {
            string connectionString = "Data Source =.; Initial Catalog = Anbar; Integrated Security = True; ";
            con = new SqlConnection(connectionString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView1.Clear();
            listView1.Columns.Add("S/s").Width = 40;
            listView1.Columns.Add("Ad").Width = 90;
            listView1.Columns.Add("Kod").Width = 90;
            listView1.Columns.Add("Ölkə").Width = 80;
            listView1.Columns.Add("Anbar").Width = 80;
            listView1.Columns.Add("Mədaxil").Width = 90;
            listView1.Columns.Add("Satılıb").Width = 90;
            listView1.Columns.Add("Qiymət").Width = 50;
            listView1.Columns.Add("Məbləğ").Width = 100;
            listView1.Columns.Add("Qalıq").Width = 100;
            //label2.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            listView1.Font = new Font(listView1.Font, FontStyle.Bold);
            countProducts = 0;

            string uHesabat = "select m.ad, m.kod, m.olke,m.miqdar,alish.AlisMiqdar,satish.SatisMiqdar,m.satis, m.satis * satish.SatisMiqdar, m.miqdar + coalesce(alish.AlisMiqdar, 0) - coalesce(satish.SatisMiqdar, 0) as QaliqStock from Mallar as m " +
            "left join(select mal_id, sum(miqdar) as SatisMiqdar from Satis_Detalli group by mal_id ) as satish on m.mal_id = satish.mal_id " +
            "left join(select mal_id, sum(miqdar) as AlisMiqdar from Alis_Detalli group by mal_id ) as alish on m.mal_id = alish.mal_id " +
            "where m.mal_id is not null ";
            if (textBox1.Text.Length > 0)
                uHesabat = uHesabat + " and m.ad like '" + ad + "%'";
            if (textBox2.Text.Length > 0)
                uHesabat = uHesabat + " and m.kod like '" + kod + "%'";
            if (textBox3.Text.Length > 0)
                uHesabat = uHesabat + " and m.olke like '" + olke + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(uHesabat, con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            int rowCount = 1;
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(rowCount.ToString());
                rowCount++;
                for (int i = 0; i < dt.Columns.Count; i++)
                    item.SubItems.Add(row[i].ToString());
                item.SubItems[7].Text = (Math.Round(decimal.Parse(item.SubItems[7].Text), 0)).ToString();
                //item.SubItems[7].Text = (Math.Round(decimal.Parse(item.SubItems[7].Text), 0)).ToString();
                if (decimal.TryParse(item.SubItems[8].Text, out decimal parsedValue))
                {
                    item.SubItems[8].Text = Math.Round(parsedValue, 0).ToString();
                }
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
                countProducts++;
            }
            con.Close();
            umumihesab(9, 8, 5, 6);
        }
        private void umumihesab(int a, int b, int c, int d)
        {
            int sum = 0;
            decimal mebl = 0;
            int al = 0;
            int sat = 0;
            int qaliqMebl = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                decimal value = 0;
                int value2 = 0;
                if (int.TryParse(item.SubItems[a].Text, out value2))
                {
                    sum += value2;
                    qaliqMebl += value2 * int.Parse(item.SubItems[7].Text);
                }
                if (decimal.TryParse(item.SubItems[b].Text, out value))
                    mebl += value;
                if (int.TryParse(item.SubItems[c].Text, out value2))
                    al += value2;
                if (int.TryParse(item.SubItems[d].Text, out value2))
                    sat += value2;
            }
            label5.Text = sum.ToString() + " əd.";
            label8.Text = mebl.ToString() + " AZN";
            label11.Text = al.ToString() + " əd.";
            label12.Text = sat.ToString() + " əd.";
            label14.Text = qaliqMebl.ToString() + " AZN";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView1.Clear();
            listView1.Columns.Add("Ad").Width = 100;
            listView1.Columns.Add("Kod").Width = 100;
            listView1.Columns.Add("Ölkə").Width = 100;
            listView1.Columns.Add("Satılıb").Width = 100;
            listView1.Columns.Add("Qiymət").Width = 80;
            listView1.Columns.Add("Məbləğ").Width = 100;
            listView1.Columns.Add("Status").Width = 140;
            //listView1.Font = new Font(listView1.Font, FontStyle.Bold);

            string finder = "";
            string query = " select m.ad, m.kod, m.olke, sum(sd.miqdar) as satisMiqdar, m.satis as qiymet,(sum(sd.miqdar) * m.satis) as mebleg, sd.status " +
                "from Satis_Detalli as sd left join Mallar as m on sd.mal_id = m.mal_id where sd.TarixD between @date1 and @date2 group by m.ad, m.kod, m.olke,m.satis,sd.status " +
                "having m.kod is not null " + finder + " order by m.kod";
            if (textBox1.Text.Length > 0)
                finder += " and m.ad like '" + ad + "%'";
            if (textBox2.Text.Length > 0)
                finder += " and m.kod like '" + kod + "%'";
            if (textBox3.Text.Length > 0)
                finder += " and m.olke like '" + olke + "%'";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("yyyy.MM.dd"));
            cmd.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("yyyy.MM.dd"));
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                    item.SubItems.Add(row[i].ToString());
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 0)).ToString();
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 0)).ToString();
                if (item.SubItems[6].Text == "True")
                    item.SubItems[6].Text = "";
                else
                {
                    item.SubItems[6].Text = "Geri qayıtma";
                    item.ForeColor = Color.Red;
                }
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
            decimal mebl = 0;
            int sat = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                decimal value = 0;
                int value2 = 0;
                if (int.TryParse(item.SubItems[3].Text, out value2))
                    sat += value2;
                if (decimal.TryParse(item.SubItems[5].Text, out value))
                    mebl += value;
            }
            label8.Text = mebl.ToString() + " AZN";
            label12.Text = sat.ToString() + " əd.";
            label11.Text = "0";
            label5.Text = "0";
        }
        string ad;
        string kod;
        string olke;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            button1_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            kod = textBox2.Text;
            button1_Click(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            olke = textBox3.Text;
            button1_Click(sender, e);
        }

        private void Hesabatlar_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            button1_Click(sender, e);
            listView2.Items.Clear();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //listView2.Items.Clear();
            listView2.Clear();
            listView2.Columns.Add("Ad").Width = 150;
            listView2.Columns.Add("Menecer").Width = 100;
            listView2.Columns.Add("Alıb").Width = 100;
            listView2.Columns.Add("Qaytarıb").Width = 100;
            listView2.Columns.Add("Satış").Width = 100;

            listView2.Font = new Font(listView1.Font, FontStyle.Bold);
            //string kod = "002";
            int alinib = 0;
            int qayidib = 0;
            int satis = 0;

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                kod = item.SubItems[2].Text;
                //MessageBox.Show(kod);
            }
            string query = "select " +
                    "M.ad_soyad, " +
                    "m.menecer, " +
                    "coalesce(Ssn.Calis, 0) , " +
                    "coalesce(Ssn.Cgeri, 0) , " +
                    "(coalesce(Ssn.Calis, 0) + coalesce(Ssn.Cgeri, 0)) " +
                "from Musteriler as M right join" +
                "(select " +
                    "S.musteri_id, " +
                    "sum(sn.alis) as Calis, " +
                    "sum(sn.geri) as Cgeri " +
                "from Satis as S right join" +
                "(select " +
                    "COALESCE(s1.qaime_id, s2.qaime_id) as qaime, " +
                    "s1.miqdar as alis, " +
                    "s2.miqdar as geri, " +
                    "COALESCE(s1.status, s2.status) as status " +
                "from (select " +
                    "sdd.qaime_id, " +
                    "sdd.miqdar, " +
                    "sdd.status " +
                "from Satis_Detalli as sdd join Mallar as mm on sdd.mal_id = mm.mal_id where mm.kod=@kod and status = 1) as s1 full join " +
                    "(select " +
                    "sdd.qaime_id, " +
                    "sdd.miqdar, " +
                    "sdd.status " +
                "from Satis_Detalli as sdd join Mallar as mm on sdd.mal_id = mm.mal_id where mm.kod=@kod and status = 0) as s2 on s1.qaime_id = s2.qaime_id) as Sn on S.qaime_id = Sn.qaime " +
                "group by s.musteri_id) as SSn on m.musteri_id = SSn.musteri_id";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kod", kod);
            adapt = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            adapt.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                alinib += int.Parse(item.SubItems[2].Text);
                qayidib += int.Parse(item.SubItems[3].Text);
                satis += int.Parse(item.SubItems[4].Text);
                listView2.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
            label18.Text = alinib.ToString();
            label20.Text = qayidib.ToString();
            label16.Text = satis.ToString();
        }
        int countProducts;
        string footerText;
        string headerText;

        private void PrintListViewContents(ListView listView, string headerText, string footerText)
        {
            PrintDocument printDocument = new PrintDocument();

            // Initialize variables for pagination
            int itemsPerPage = 35; // Adjust as needed
            int totalItems = listView.Items.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            int currentPage = 1;
            int startIndex = 0;

            printDocument.PrintPage += (sender, e) =>
            {
                float yPos = 20;
                float xPos;
                float rowHeight = listView.Font.Height + 5;

                // Calculate column widths
                float[] columnWidths = new float[listView.Columns.Count];
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    columnWidths[i] = listView.Columns[i].Width;
                }

                // Draw header
                Font headerFont = new Font(listView.Font.FontFamily, 20, FontStyle.Bold);
                SizeF headerSize = e.Graphics.MeasureString(headerText, headerFont);
                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, (e.PageBounds.Width - headerSize.Width) / 2, yPos);
                yPos += headerSize.Height + 10;

                // Draw column headers and lines
                xPos = 20;
                using (Pen pen = new Pen(Color.Black))
                {
                    // Draw a line at the top of the table
                    e.Graphics.DrawLine(pen, xPos, yPos, xPos + columnWidths.Sum(), yPos);
                    yPos += 5;

                    // Draw column headers
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        e.Graphics.DrawString(listView.Columns[i].Text, listView.Font, Brushes.Black, xPos, yPos);
                        xPos += columnWidths[i];
                    }
                    yPos += rowHeight;

                    // Draw line after column headers
                    e.Graphics.DrawLine(pen, 20, yPos, 20 + columnWidths.Sum(), yPos);
                }

                // Draw ListView content
                for (int i = startIndex; i < Math.Min(startIndex + itemsPerPage, totalItems); i++)
                {
                    var item = listView.Items[i];
                    xPos = 20;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        e.Graphics.DrawString(subItem.Text, listView.Font, Brushes.Black, xPos, yPos);
                        xPos += columnWidths[item.SubItems.IndexOf(subItem)];
                    }
                    yPos += rowHeight;

                    // Draw horizontal gridline after each row
                    using (Pen pen = new Pen(Color.Black))
                    {
                        e.Graphics.DrawLine(pen, 20, yPos, 20 + columnWidths.Sum(), yPos);
                    }
                }

                // Draw vertical gridlines
                xPos = 20;
                using (Pen pen = new Pen(Color.Black))
                {
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        e.Graphics.DrawLine(pen, xPos, 70, xPos, yPos);
                        xPos += columnWidths[i];
                    }
                    // Draw the last vertical line on the right side
                    e.Graphics.DrawLine(pen, xPos, 70, xPos, yPos);
                }

                // Footer text  
                Font footerFont = new Font(listView.Font.FontFamily, 10, FontStyle.Italic);
                SizeF footerSize = e.Graphics.MeasureString(footerText, footerFont);
                float footerYPos = e.PageBounds.Height - footerSize.Height - 30; // Position the footer at the bottom of the page
                e.Graphics.DrawString(footerText, footerFont, Brushes.Black, 25, footerYPos);   //(e.PageBounds.Width - footerSize.Width ) / 2, footerYPos);

                // Page number
                string pageNumberText = $"{currentPage}";
                SizeF pageNumberSize = e.Graphics.MeasureString(pageNumberText, footerFont);
                e.Graphics.DrawString(pageNumberText, footerFont, Brushes.Black, e.PageBounds.Width - pageNumberSize.Width - 15, 10);


                // Increment page number and check if another page is needed
                currentPage++;
                e.HasMorePages = currentPage <= totalPages;
                if (!e.HasMorePages)
                {
                    // Reset pagination variables for next print
                    currentPage = 1;
                    startIndex = 0;
                }
                else
                {
                    // Move to the next set of items for the next page
                    startIndex += itemsPerPage;
                }
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        DateTime currentDate = DateTime.Now;

        private void button5_Click(object sender, EventArgs e)
        {
            headerText = $"Məhsul Hesabat   ({currentDate.ToString("yyyy-MM-dd")})";
            footerText = countProducts + " sayda                                                                                       " + label11.Text + "               " + label12.Text + "                       " + label8.Text + "           " + label5.Text;
            PrintListViewContents(listView1, headerText, footerText);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
