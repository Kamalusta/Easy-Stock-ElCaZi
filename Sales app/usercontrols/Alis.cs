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
        public Alis()
        {
            InitializeComponent();
            InitializeDatabase();
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
        }

        decimal totalSum = 0;
        public void SumCalc()
        {
            totalSum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal cellValue))
                    totalSum += cellValue;
            }
            label7.Text = totalSum + " AZN";
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
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 2)).ToString();
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 2)).ToString();
                listView1.Items.Add(item);
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
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 2)).ToString();
                listView2.Items.Add(item);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
                    textBox7.Text = "0,00";
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
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 2)).ToString();
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 2)).ToString();

                listView1.Items.Add(item);
            }
            con.Close();
        }
    }
}
