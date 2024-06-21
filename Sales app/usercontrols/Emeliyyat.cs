using System.Data;
using System.Data.SqlClient;

namespace Sales_app.usercontrols
{
    public partial class Emeliyyat : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private DataTable dataTable;

        bool status = true;
        string selected;
        int sum = 0;
        decimal sum2 = 0;
        string satis_dt_id;
        decimal mebleg = 0;

        public Emeliyyat(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }

        private void Emeliyyat_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView2.Font = new Font(listView2.Font, FontStyle.Bold);
            listView1.Font = new Font(listView1.Font, FontStyle.Bold);

            string kassamedaxil = " and s.mebleg <> 0 ";

            if (button3.ForeColor == Color.Red)
            {
                status = false;
                kassamedaxil = " and s.mebleg = 0 ";
            }
            string query = "select s.qaime_id, m.ad_soyad, s.mebleg, s.odendi, s.tarix " +
                "from Satis s join Musteriler m on s.musteri_id=m.musteri_id " +
                "where s.status=@status " + kassamedaxil + " order by s.tarix desc, s.qaime_id desc";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", status);

            adapt = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            adapt.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                // for (int i = 1; i < dataTable.Columns.Count; i++)
                item.SubItems.Add(dr[1].ToString());
                if (dr[2].ToString() == "")
                    dr[2] = "0";
                item.SubItems.Add(Math.Round(decimal.Parse(dr[2].ToString()), 0).ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[3].ToString()), 0).ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy"));

                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void datagetir(string ad)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            //button1.ForeColor = Color.Red;
            string name = " ";
            if (ad != null)
            {
                name = " and m.ad_soyad like '" + ad + "%' ";
            }

            string kassamedaxil = " and s.mebleg <> 0 ";

            if (button3.ForeColor == Color.Red)
            {
                status = false;
                kassamedaxil = " and s.mebleg = 0 ";
            }
            string query = "select s.qaime_id, m.ad_soyad, s.mebleg, s.odendi, s.tarix " +
                "from Satis s join Musteriler m on s.musteri_id=m.musteri_id " +
                "where s.status=@status " + kassamedaxil + name + " order by s.tarix desc, s.qaime_id desc";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", status);

            adapt = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            adapt.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                // for (int i = 1; i < dataTable.Columns.Count; i++)
                item.SubItems.Add(dr[1].ToString());
                if (dr[2].ToString() == "")
                    dr[2] = "0";
                item.SubItems.Add(Math.Round(decimal.Parse(dr[2].ToString()), 0).ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[3].ToString()), 0).ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy"));
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            button2.ForeColor = Color.Red;
            button1.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            label4.Text = "Mədaxil Qaimələr";
            textBox1.Clear();
            textBox1.Visible = false;
            label5.Visible = false;

            string query = "select s.qaime_id, m.ad_soyad, s.mebleg, s.odendi, s.tarix " +
                "from Alis s join Musteriler m on s.konturaagent_id=m.musteri_id order by s.tarix desc, s.qaime_id desc";
            cmd = new SqlCommand(query, con);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            adapt.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                // for (int i = 1; i < dataTable.Columns.Count; i++)
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[2].ToString()), 0).ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[3].ToString()), 0).ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy"));
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = true;
            listView1.Items.Clear();
            listView2.Items.Clear();
            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            label4.Text = "Məxaric Qaimələr";
            textBox1.Clear();
            Emeliyyat_Load(sender, e);
            textBox1.Visible = true;
            label5.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            listView2.Items.Clear();
            label3.Text = "0";
            sum = 0;
            sum2 = 0;
            label21.Text = sum.ToString();
            label22.Text = sum2.ToString();
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selected = selectedItem.SubItems[0].Text;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            sum = 0;
            sum2 = 0;
            label3.Text = selected;
            listView2.Items.Clear();
            string query = "select m.ad, m.kod, m.olke, sd.miqdar, sd.ani_qiymet, sd.id, m.mal_id " +
            "from Satis_Detalli sd join Mallar m on sd.mal_id=m.mal_id where qaime_id =" + selected;
            if (button2.ForeColor == Color.Red)
            {
                query = "select m.ad, m.kod, m.olke, sd.miqdar, sd.ani_qiymet, sd.id, m.mal_id " +
                "from Alis_Detalli sd join Mallar m on sd.mal_id=m.mal_id where qaime_id =" + selected;
            }
            cmd = new SqlCommand(query, con);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            adapt.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < dataTable.Columns.Count; i++)
                    item.SubItems.Add(dr[i].ToString());
                decimal colm4 = (Math.Round(decimal.Parse(item.SubItems[4].Text), 0));
                item.SubItems[4].Text = colm4.ToString();
                item.SubItems[5].Text = (colm4 * Int16.Parse(item.SubItems[3].Text)).ToString();
                listView2.Items.Add(item);
                sum += int.Parse(item.SubItems[3].Text);
                sum2 += decimal.Parse(item.SubItems[5].Text);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
            label21.Text = sum.ToString();
            label22.Text = sum2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status = false;
            listView1.Items.Clear();
            listView2.Items.Clear();
            button3.ForeColor = Color.Red;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            label4.Text = "Kassa Mədaxil";
            textBox1.Clear();
            Emeliyyat_Load(sender, e);
            textBox1.Visible = true;
            label5.Visible = true;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal mebleg2 = decimal.Parse(textBox4.Text) * decimal.Parse(textBox5.Text);
            decimal yekun = mebleg - mebleg2;
            DialogResult sorgu = MessageBox.Show("Dəyişiklik etməyə əminsiniz ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                string query_update = "update Satis_Detalli set miqdar=@miqdar ,ani_qiymet=@qiymet where id=@id ";
                string query_satis_up = "update Satis set mebleg -= @yekun where qaime_id = @qaime";
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(query_update, con, transaction);
                    cmd.Parameters.AddWithValue("@miqdar", textBox4.Text);
                    cmd.Parameters.AddWithValue("@qiymet", textBox5.Text);
                    cmd.Parameters.AddWithValue("@id", satis_dt_id);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query_satis_up, con, transaction);
                    cmd2.Parameters.AddWithValue("@yekun", yekun);
                    cmd2.Parameters.AddWithValue("@qaime", selected);
                    cmd2.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Məhsul uğurla dəyişdirildi");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Xeta bas verdi " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            panel1.Visible = false;
            listView1_DoubleClick(sender, e);
            Emeliyyat_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query_delete = "delete from Satis_Detalli where id = @id";
            string query_satis_up = "update Satis set mebleg -= @mebleg where qaime_id = @qaime";
            DialogResult sorgu = MessageBox.Show("Məhsulu silməyə əminsiniz ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(query_delete, con, transaction);

                    cmd.Parameters.AddWithValue("@id", satis_dt_id);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query_satis_up, con, transaction);
                    cmd2.Parameters.AddWithValue("@mebleg", mebleg);
                    cmd2.Parameters.AddWithValue("@qaime", selected);
                    cmd2.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Məhsul uğurla silindi");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Xeta bas verdi " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                panel1.Visible = false;
                Emeliyyat_Load(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            textBox2.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal mebleg = Convert.ToDecimal(textBox4.Text) * Convert.ToDecimal(textBox5.Text);
            string query = "insert into Satis_Detalli (qaime_id, mal_id, miqdar, ani_qiymet, status) " +
                "values(@selected, (select mal_id from Mallar where kod = @kod), @miqdar, @qiymet, 1)";
            string query_satis_up = "update Satis set mebleg += @mebleg where qaime_id = @qaime";

            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.Parameters.AddWithValue("@selected", selected);
                cmd.Parameters.AddWithValue("@kod", textBox2.Text);
                cmd.Parameters.AddWithValue("@miqdar", textBox4.Text);
                cmd.Parameters.AddWithValue("@qiymet", textBox5.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(query_satis_up, con, transaction);
                cmd2.Parameters.AddWithValue("@mebleg", mebleg);
                cmd2.Parameters.AddWithValue("@qaime", selected);
                cmd2.ExecuteNonQuery();
                transaction.Commit();

                MessageBox.Show("Məhsul əlavə edildi");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Xeta bas verdi " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            panel1.Visible = false;
            Emeliyyat_Load(sender, e);
        }

        private void dəyişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selected = selectedItem.SubItems[0].Text;
                label14.Text = selected;
                textBox6.Text = selectedItem.SubItems[1].Text;
                textBox7.Text = selectedItem.SubItems[2].Text;
                textBox8.Text = selectedItem.SubItems[3].Text;
                dateTimePicker1.Text = selectedItem.SubItems[4].Text;

                panel2.Visible = true;
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            listView1_DoubleClick(sender, e);
            dataGridView1.Columns.Add("Ad", "Ad");
            dataGridView1.Columns.Add("Kod", "Kod");
            dataGridView1.Columns.Add("Miqdar", "Miqdar");
            dataGridView1.Columns.Add("Qiymət", "Qiymət");
            //dataGridView1.Columns.Add("malID", "malID");

            dataGridView1.Columns[0].ReadOnly = true;
            //dataGridView1.Columns[4].Visible = false;

            foreach (ListViewItem item in listView2.Items)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = item.SubItems[0].Text;
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.SubItems[1].Text;
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.SubItems[3].Text;
                dataGridView1.Rows[rowIndex].Cells[3].Value = item.SubItems[4].Text;
                //dataGridView1.Rows[rowIndex].Cells[4].Value = item.SubItems[6].Text;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string typedText = textBox6.Text;
            listBox1.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT ad_soyad FROM Musteriler WHERE status = 0 and ad_soyad LIKE @typedText + '%'", con);
            cmd.Parameters.AddWithValue("@typedText", typedText);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;

            string queryUpSa = "update Satis set mebleg = @mebleg, odendi = @odendi, tarix = @tarix, musteri_id = @mId where qaime_id = @qaime";
            string queryDeSD = "Delete Satis_Detalli where qaime_id = @qaime";
            string queryInSD = "insert into Satis_Detalli(qaime_id, mal_id, miqdar, ani_qiymet, TarixD, status) " +
                "values(@qaime, (select mal_id from Mallar where kod = @kod), @miqdar, @ani_qiymet, @tarix2, @status)";

            //string query = "insert into Satis(musteri_id, mebleg, odendi, tarix, status) values(@musteri, @mebleg, @odendi, @tarix, @status);SELECT SCOPE_IDENTITY();";

            if (button2.ForeColor == Color.Red)
            {
                queryUpSa = "update Alis set mebleg = @mebleg, odendi = @odendi, tarix = @tarix, konturaagent_id = @mId where qaime_id = @qaime";
                queryDeSD = "Delete Alis_Detalli where qaime_id = @qaime";
                queryInSD = "insert into Alis_Detalli(qaime_id, mal_id, miqdar, ani_qiymet, TarixD) " +
                "values(@qaime, (select mal_id from Mallar where kod = @kod), @miqdar, @ani_qiymet, @tarix2)";
            }

            con.Open();
            int mId = -1;
            try
            {
                string query1 = "Select musteri_id from Musteriler where ad_soyad = @ad";
                cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@ad", textBox6.Text);
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                    mId = reader1.GetInt32(0);
                reader1.Close();
                if (mId < 0)
                {
                    throw new Exception("Müştəri adını düzgün daxil edin");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }

            SqlTransaction sqlTransaction = con.BeginTransaction();
            try
            {
                bool flag = true;
                cmd = new SqlCommand(queryDeSD, con, sqlTransaction);
                cmd.Parameters.AddWithValue("@qaime", label14.Text);
                cmd.ExecuteNonQuery();
                decimal mebleg = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    if (row.Cells[1].Value == null || row.Cells[3].Value == null || row.Cells[2].Value == null)
                    {
                        MessageBox.Show("Xanaları tam doldurun");
                        sqlTransaction.Rollback();
                        flag = false;
                        break;
                    }
                    string kod = row.Cells[1].Value.ToString();
                    decimal qiymet = decimal.Parse(row.Cells[3].Value.ToString());
                    int miqdar = int.Parse(row.Cells[2].Value.ToString());
                    mebleg += qiymet * miqdar;
                    cmd = new SqlCommand(queryInSD, con, sqlTransaction);
                    cmd.Parameters.AddWithValue("@qaime", label14.Text);
                    cmd.Parameters.AddWithValue("@kod", kod);
                    cmd.Parameters.AddWithValue("@miqdar", miqdar);
                    cmd.Parameters.AddWithValue("@ani_qiymet", qiymet);
                    cmd.Parameters.AddWithValue("tarix2", dateTimePicker1.Value);
                    if (button2.ForeColor != Color.Red)
                        cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }

                if (flag & mId >= 0)
                {
                    cmd = new SqlCommand(queryUpSa, con, sqlTransaction);
                    cmd.Parameters.AddWithValue("@mebleg", mebleg);
                    cmd.Parameters.AddWithValue("@odendi", decimal.Parse(textBox8.Text));
                    cmd.Parameters.AddWithValue("@tarix", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@mId", mId);
                    cmd.Parameters.AddWithValue("@qaime", label14.Text);
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    MessageBox.Show("Əməliyyat uğurla icra edildi ");
                }
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show("Xeta bas verdi \n" + ex.Message);
            }
            finally
            {
                con.Close();
                panel2.Visible = false;
                if (button2.ForeColor == Color.Red)
                    button2_Click(sender, e);
                else
                    Emeliyyat_Load(sender, e);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            listBox1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox6.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selected = selectedItem.SubItems[0].Text;
            }
            DialogResult sorgu = MessageBox.Show("Qaiməni silməyə əminsiniz ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                try
                {
                    string queryDeS = "Delete Satis_Detalli where qaime_id = @qaime; Delete Satis where qaime_id = @qaime";
                    if (button2.ForeColor == Color.Red)
                        queryDeS = "Delete Alis_Detalli where qaime_id = @qaime; Delete Alis where qaime_id = @qaime";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryDeS, con);
                    cmd.Parameters.AddWithValue("@qaime", selected);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Qaimə uğurla silindi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme mümkün olmadı " + ex);
                }
                finally
                {
                    con.Close();
                    if (button2.ForeColor == Color.Red)
                        button2_Click(sender, e);
                    else
                        Emeliyyat_Load(sender, e);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            datagetir(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            status = false;
            button10.ForeColor = Color.Red;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            label4.Text = "Geri Qayıdan";

            Emeliyyat_Load(sender, e);
            textBox1.Clear();
        }

    }
}
