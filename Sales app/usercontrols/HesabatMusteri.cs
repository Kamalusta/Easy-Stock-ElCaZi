using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Sales_app.usercontrols
{
    public partial class HesabatMusteri : UserControl
    {
        private SqlConnection con;
        public HesabatMusteri(SqlConnection conn)
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

        private void HesabatMusteri_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            listView1.Clear();
            listView1.Columns.Add("S/s").Width = 40;
            listView1.Columns.Add("Ad").Width = 150;
            listView1.Columns.Add("Menecer").Width = 100;
            listView1.Columns.Add("Məbləğ").Width = 110;
            listView1.Columns.Add("Ödədi").Width = 90;
            listView1.Columns.Add("Miqdar").Width = 90;
            listView1.Columns.Add("Köhnə Borc").Width = 100;
            listView1.Columns.Add("Ümumi Borc").Width = 100;

            listView2.Clear();
            listView2.Columns.Add("Qaimə id").Width = 90;
            listView2.Columns.Add("Məhsul miq.").Width = 100;
            listView2.Columns.Add("Məbləğ").Width = 110;
            listView2.Columns.Add("Ödədi").Width = 90;
            listView2.Columns.Add("Tarix").Width = 100;
            listView2.Columns.Add("Status").Width = 140;

            datagetir(search_name, search_manag);
            //musterisiyahi("");
        }
        DateTime currentDate = DateTime.Now;
        string search_name = "";
        string search_manag = "";
        string date1 = "";
        string date2 = "";
        string date = "";
        int countCustomers = 0;

        private void datagetir(string name, string manag)
        {
            countCustomers = 0;
            int mebleg = 0;
            int miqdar = 0;
            int odedi = 0;
            int borc = 0;
            int kohneborc = 0;
            listView1.Items.Clear();
            listView1.Font = new Font(listView1.Font, FontStyle.Bold);
            listView2.Font = new Font(listView2.Font, FontStyle.Bold);
            /*date = "";
           if (date1 != "")
               date = " and s.tarix between '" + date1 + "' and '" + date2+"'";*/
            string name2 = "and m.ad_soyad like '" + name + "%' ";
            string manag2 = "and m.menecer like '" + manag + "%' ";
            string query = "select m.ad_soyad, m.menecer, coalesce(cast(sum(s.mebleg) as int), 0) as mebleg, coalesce(cast(sum(s.odendi) as int), 0) as odedi, coalesce(sum(sd.miq), 0) as miqdar, " +
                " cast (m.borc as int), cast((coalesce(sum(s.mebleg), 0) - coalesce(sum(s.odendi), 0) + m.borc) as int) as borc from Musteriler m " +
                "left join Satis s on m.musteri_id = s.musteri_id " +
                "left join (select qaime_id, sum(miqdar) as miq from Satis_Detalli group by qaime_id) sd on s.qaime_id = sd.qaime_id " +
                "where m.status = 0 " + name2 + manag2 + date + " group by m.musteri_id, m.ad_soyad, m.menecer, m.borc order by m.musteri_id";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int rowCount = 1; // Initialize the row count
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(rowCount.ToString()); // Add the row count as the first column
                rowCount++; // Increment the row count for the next row

                for (int i = 0; i < dt.Columns.Count; i++) // Start from 0 to include all columns from the data table
                {
                    item.SubItems.Add(dr[i].ToString());
                }

                if (int.Parse(item.SubItems[7].Text) != borcSearched) // Assuming borcSearched is the 7th column in the DataTable
                {
                    listView1.Items.Add(item);
                    item.Font = new Font(item.Font, FontStyle.Regular);
                    mebleg += int.Parse(item.SubItems[3].Text); // Assuming mebleg is the 3rd column
                    miqdar += int.Parse(item.SubItems[5].Text); // Assuming miqdar is the 5th column
                    odedi += int.Parse(item.SubItems[4].Text); // Assuming odedi is the 4th column
                    borc += int.Parse(item.SubItems[7].Text); // Assuming borc is the 7th column
                    kohneborc += int.Parse(item.SubItems[6].Text); // Assuming kohneborc is the 6th column
                    countCustomers++;
                }
            }

            /* foreach (DataRow dr in dt.Rows)
             {
                 ListViewItem item = new ListViewItem(dr[0].ToString());
                 for (int i = 1; i < dt.Columns.Count; i++)
                 {
                     item.SubItems.Add(dr[i].ToString());
                 }
                 if (int.Parse(item.SubItems[6].Text) != borcSearched)
                 {
                     listView1.Items.Add(item);
                     item.Font = new Font(item.Font, FontStyle.Regular);
                     mebleg += int.Parse(item.SubItems[2].Text);
                     miqdar += int.Parse(item.SubItems[4].Text);
                     odedi += int.Parse(item.SubItems[3].Text);
                     borc += int.Parse(item.SubItems[6].Text);
                     kohneborc += int.Parse(item.SubItems[5].Text);
                     countCustomers++;
                 }
             }*/
            label11.Text = mebleg.ToString() + " azn";
            label12.Text = odedi.ToString() + " azn";
            label8.Text = miqdar.ToString() + " əd";
            label5.Text = borc.ToString() + " azn";
            label4.Text = kohneborc.ToString() + " azn";
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search_name = textBox1.Text.ToLower();
            datagetir(search_name, search_manag);
        }
        string select = "";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView2.Font = new Font(listView2.Font, FontStyle.Bold);

            string select = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                select = selectedItem.SubItems[1].Text;
            }
            label14.Text = select;  
            string query = "  select s.qaime_id, sd.miq, cast(mebleg as int), cast(odendi as int), tarix, status from Satis s" +
                " left join (select qaime_id, sum(miqdar) as miq from Satis_Detalli group by qaime_id) sd on s.qaime_id = sd.qaime_id" +
                " where musteri_id =(select musteri_id from Musteriler where ad_soyad=@name) " + date + " order by tarix desc";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", select);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                item.SubItems[4].Text = Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy");
                if (item.SubItems[5].Text == "False")
                    if (item.SubItems[2].Text == "0")
                    {
                        item.SubItems[5].Text = "Kassa Mədaxil";
                        item.ForeColor = Color.Green;
                    }
                    else
                    {
                        item.SubItems[5].Text = "Geri qayıtma";
                        item.ForeColor = Color.Red;
                    }
                else
                {
                    item.SubItems[5].Text = "Satış";
                    item.SubItems[5].ForeColor = Color.Blue;
                }
                listView2.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            listView2.Items.Clear();
            date1 = dateTimePicker1.Value.ToString("yyyy.MM.dd");
            date2 = dateTimePicker2.Value.ToString("yyyy.MM.dd");
            date = " and s.tarix between '" + date1 + "' and '" + date2 + "'";
            datagetir(search_name, search_manag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            date = "";
            listView2.Items.Clear();
            textBox1.Clear();
            datagetir(search_name, search_manag);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search_manag = textBox2.Text.ToLower();
            datagetir(search_name, search_manag);
        }

        string footerText;
        string headerText;
        int borcSearched = -1;

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor == Color.Black)
            {
                button3.ForeColor = Color.Red;
                borcSearched = 0;
            }
            else
            {
                button3.ForeColor = Color.Black;
                borcSearched = -1;
            }
            datagetir(search_name, search_manag);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            headerText = label14.Text + $"   ({currentDate.ToString("yyyy-MM-dd")})";
            footerText = "";
            PrintListViewContents(listView2, headerText, footerText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tarix = currentDate.ToString("yyyy-MM-dd");
            headerText = $"Müştəri Hesabatı    ({tarix})";
            footerText = "         " + countCustomers + " sayda                                                      " + label11.Text + "            " + label12.Text + "          " + label8.Text + "             " + label4.Text + "             " + label5.Text;
            PrintListViewContents(listView1, headerText, footerText);
        }
    }
}
