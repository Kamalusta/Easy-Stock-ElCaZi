using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sales_app.usercontrols
{
    public partial class Alis : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd, cmd2, cmd3;
        private SqlDataAdapter adapt;
        private DataTable dataTable;
        //Satis satis = new Satis();
        public Alis(SqlConnection conn)
        {
            InitializeComponent();
            //InitializeDatabase();
            con = conn;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dataTable = new DataTable();
            dataTable.Columns.Add("Mal ID", typeof(string));
            dataTable.Columns.Add("Mal kodu", typeof(string));
            dataTable.Columns.Add("Ani Qiymet", typeof(string));
            dataTable.Columns.Add("Miqdar", typeof(string));
            dataTable.Columns.Add("Mebleg", typeof(string));
        }

        private void InitializeDatabase()
        {
            //string connectionString = "Data Source=.;Initial Catalog=Anbar;User ID=sa;Password=12345678;";
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";

            con = new SqlConnection(connectionString);
        }

        private void Alis_Load(object sender, EventArgs e)
        {
            mal_siyahi();
            musteri_siyahi();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            //dataGridView1.Columns[5].Width = 200;
            listView1.Font = new Font(listView1.Font, FontStyle.Bold);
            listView2.Font = new Font(listView2.Font, FontStyle.Bold);
            dateTimePicker1.Value = DateTime.Now;
        }

        decimal totalSum = 0;
        decimal sumMiq = 0;

        public void SumCalc()
        {
            totalSum = 0;
            sumMiq = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal cellValue))
                    totalSum += cellValue;
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal cellValue1))
                    sumMiq += cellValue1;
            }
            label7.Text = totalSum + " AZN";
            label21.Text = sumMiq.ToString();
            label22.Text = label7.Text;
        }

        public void mal_siyahi()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Mallar", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                    item.SubItems.Add(row[i].ToString());
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 0)).ToString();
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 0)).ToString();
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        public void musteri_siyahi()
        {
            listView2.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler where status=1", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                    item.SubItems.Add(row[i].ToString());
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 0)).ToString();
                listView2.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        string mal_kod;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                textBox5.Text = selectedItem.SubItems[0].Text;
                textBox3.Text = selectedItem.SubItems[5].Text;
                mal_kod = selectedItem.SubItems[2].Text;

                if (panel4.Visible == true)
                {
                    textBox12.Text = selectedItem.SubItems[1].Text;
                    textBox11.Text = selectedItem.SubItems[2].Text;
                    textBox10.Text = selectedItem.SubItems[3].Text;
                    textBox9.Text = selectedItem.SubItems[4].Text;
                    textBox8.Text = selectedItem.SubItems[5].Text;
                    textBox6.Text = selectedItem.SubItems[6].Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                string value1 = textBox5.Text;
                string value2 = textBox3.Text;
                string value3 = textBox4.Text;
                string value4 = (decimal.Parse(textBox3.Text) * int.Parse(textBox4.Text)).ToString();

                DataRow newRow = dataTable.NewRow();
                newRow["Mal ID"] = value1;
                newRow["Mal kodu"] = mal_kod;
                newRow["Ani Qiymet"] = value2;
                newRow["Miqdar"] = value3;
                newRow["Mebleg"] = value4;

                dataTable.Rows.Add(newRow);
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                mal_kod = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Xanalari duzgun doldur");
            }
            SumCalc();
        }

        int secilen = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (secilen >= 0)
            {
                dataGridView1.Rows.RemoveAt(secilen);
                SumCalc();
            }
            else MessageBox.Show("Secilmis setr yoxdur");
            secilen = -1;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = e.RowIndex;
        }

        int musteri_id = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (musteri_id >= 0)
            {
                if (totalSum > 0)
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        string query = "insert into Alis(konturaagent_id, mebleg, odendi, tarix) values(@musteri, @mebleg, @odendi, @tarix);SELECT SCOPE_IDENTITY();";
                        string query_detalli = "insert into Alis_Detalli(qaime_id, mal_id, miqdar, ani_qiymet, TarixD) values(@qaime, @mal_id, @miqdar, @ani_qiymet, @tarix2)";
                        cmd = new SqlCommand(query, con, transaction);
                        cmd.Parameters.AddWithValue("@musteri", musteri_id);
                        cmd.Parameters.AddWithValue("@mebleg", totalSum);
                        cmd.Parameters.AddWithValue("@odendi", totalSum);
                        cmd.Parameters.AddWithValue("@tarix", dateTimePicker1.Value);
                        int primaryKeyValue = Convert.ToInt32(cmd.ExecuteScalar());
                        /*if (decimal.Parse(textBox7.Text) != totalSum)
                        {
                            decimal res = totalSum - decimal.Parse(textBox7.Text);
                            string query4 = "update Musteriler set borc = borc - @res where musteri_id = " + musteri_id;
                            cmd = new(query4, con, transaction);
                            cmd.Parameters.AddWithValue("@res", res);
                            cmd.ExecuteNonQuery();
                        }*/
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            int id = int.Parse(row.Cells[0].Value.ToString());
                            decimal qiymet = decimal.Parse(row.Cells[2].Value.ToString());
                            int miqdar = int.Parse(row.Cells[3].Value.ToString());

                            /* string query1 = "select miqdar from Mallar where mal_id =" + id;
                             cmd3 = new(query1, con, transaction);
                             object result = cmd3.ExecuteScalar();
                             if (int.Parse(result.ToString()) < miqdar)
                             {
                                 DialogResult sorgu = MessageBox.Show("DİQQƏT ! \n" + id + " id nomreli məhsul stokda yoxdur.\n Yenə də əməliyyat davam etsin ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                 if (sorgu == DialogResult.No)
                                 {
                                     transaction.Rollback();
                                     MessageBox.Show("Əməliyyat icra edilmədi !");
                                 }
                             }*/
                            cmd2 = new SqlCommand(query_detalli, con, transaction);
                            cmd2.Parameters.AddWithValue("@qaime", primaryKeyValue);
                            cmd2.Parameters.AddWithValue("@mal_id", id);
                            cmd2.Parameters.AddWithValue("@miqdar", miqdar);
                            cmd2.Parameters.AddWithValue("@ani_qiymet", qiymet);
                            cmd2.Parameters.AddWithValue("@tarix2", dateTimePicker1.Value);
                            cmd2.ExecuteNonQuery();
                            //int res = int.Parse(result.ToString()) - miqdar;
                            /*string query2 = "update Mallar set miqdar += " + miqdar + " where mal_id = " + id;
                            cmd3 = new(query2, con, transaction);
                            cmd3.ExecuteNonQuery();*/
                        }
                        transaction.Commit();
                        MessageBox.Show("Məhsullar mədaxil edildi");
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Xeta bas verdi" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                    dataTable.Clear();
                    SumCalc();
                    musteri_id = -1;
                    textBox1.Clear();
                    textBox7.Text = "0";
                    label9.Text = "Secilmeyib";
                }
                else MessageBox.Show("Mədaxil hesabatı getməmişdir");
            }
            else MessageBox.Show("Konturagent seçimi etməmisiniz");
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                musteri_id = int.Parse(selectedItem.Text);
                label9.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string typedText = textBox1.Text;
            listView1.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Mallar WHERE kod LIKE @typedText + '%'", con);
            cmd.Parameters.AddWithValue("@typedText", typedText);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 0)).ToString();
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 0)).ToString();
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clearbtn();
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new("select kod from Mallar where kod = @kod", con);
            cmd1.Parameters.AddWithValue("@kod", textBox11.Text);
            object result = cmd1.ExecuteScalar();
            con.Close();
            if (result == null)
            {
                decimal value1, value2;
                int value3;
                if (decimal.TryParse(textBox9.Text, out value1) && decimal.TryParse(textBox8.Text, out value2) && int.TryParse(textBox6.Text, out value3))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new("insert into Mallar(ad, kod, olke, alis, satis, miqdar) values(@ad, @kod, @olke, @alis, @satis, @miqdar)", con);
                        cmd.Parameters.AddWithValue("@ad", textBox12.Text);
                        cmd.Parameters.AddWithValue("@kod", textBox11.Text);
                        cmd.Parameters.AddWithValue("@olke", textBox10.Text);
                        cmd.Parameters.AddWithValue("@alis", value1);
                        cmd.Parameters.AddWithValue("@satis", value2);
                        cmd.Parameters.AddWithValue("@miqdar", value3);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Məhsul uğurla əlavə edildi");
                        panel4.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xeta bas verdi " + ex);
                    }

                    clearbtn();
                    mal_siyahi();
                }
                else
                    MessageBox.Show("Məlumatları düzgün doldurun");
            }
            else MessageBox.Show(textBox11.Text + " Bu kodda məhsul var ! Zəhmət olmasa unikal bir kod daxil edin");

        }
        public void clearbtn()
        {
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox6.Clear();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4.Focus();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                SumCalc();
            }
        }
    }
}
