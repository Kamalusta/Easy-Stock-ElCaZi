using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sales_app.usercontrols
{
    public partial class Satis : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd, cmd2, cmd3;
        private SqlDataAdapter adapt;
        private DataTable dataTable;
        Form1 form1 = new ();
        public Satis()
        {
            InitializeComponent();
            InitializeDatabase();

            dateTimePicker1.Format= DateTimePickerFormat.Short;
        }

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }

        decimal totalSum = 0;
        decimal sumMiq = 0;
               

        
public void SumCalc()
        {
            totalSum = 0;
            sumMiq = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null && decimal.TryParse(row.Cells[5].Value.ToString(), out decimal cellValue))                
                    totalSum += cellValue;
                if (row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal cellValue1))
                    sumMiq += cellValue1;
            }
            label7.Text = totalSum + " AZN";
            label21.Text = sumMiq.ToString();
            label22.Text = label7.Text;
        }

        public void mal_siyahi()
        {
            listView2.Items.Clear();
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
                listView2.Items.Add(item);
            }
            con.Close();
        }

        public void musteri_siyahi()
        {
            string query = "select m.musteri_id, m.ad_soyad, m.elaqe,m.unvan, m.menecer, m.kategoriya, sum(s.mebleg) - sum(odendi) " +
                " from Musteriler m left join Satis s on m.musteri_id=s.musteri_id" +
                " where m.status=0 " +
                " group by m.musteri_id, ad_soyad, elaqe, kategoriya, unvan, menecer, borc";
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)                
                    item.SubItems.Add(row[i].ToString());
                if (item.SubItems[6].Text == "")
                {
                    item.SubItems[6].Text = "0";
                }
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 2)).ToString();
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string value2 = textBox3.Text;
                string value3 = textBox4.Text;
                string value4 = (decimal.Parse(textBox3.Text) * int.Parse(textBox4.Text)).ToString();                

                DataRow newRow = form1.dataTable2.NewRow();
                newRow["Malın adı"] = mal_adi;
                newRow["Mal id"] = mal_id;
                newRow["Mal kodu"] = mal_kod;
                newRow["Ani Qiymət"] = value2;
                newRow["Miqdar"] = value3;
                newRow["Məbləğ"] = value4;

                form1.dataTable2.Rows.Add(newRow);
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                mal_kod = "";                               
            }
            catch (Exception)
            {
                MessageBox.Show("Xanaları düzgün doldur");
            }
            SumCalc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string typedText = textBox2.Text;
            listView2.Items.Clear();
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

                listView2.Items.Add(item);
            }
            con.Close();
        }
        string mal_kod;
        string mal_adi;
        string mal_id;
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                mal_id = selectedItem.SubItems[0].Text;
                mal_adi = selectedItem.SubItems[1].Text;
                mal_kod = selectedItem.SubItems[2].Text;
                textBox3.Text = selectedItem.SubItems[5].Text;
                textBox5.Text = mal_kod;

                if (panel4.Visible==true)
                {                    
                    textBox12.Text = selectedItem.SubItems[1].Text;
                    textBox11.Text = selectedItem.SubItems[2].Text;
                    textBox10.Text = selectedItem.SubItems[3].Text;
                    textBox9.Text = selectedItem.SubItems[4].Text;
                    textBox8.Text = selectedItem.SubItems[5].Text;
                    textBox6.Text = selectedItem.SubItems[6].Text;
                }
            }
            if (textBox5.Text.Length > 0)
            {
                string query1 = "select m.miqdar + coalesce(alish.AlisMiqdar, 0) - coalesce(satish.SatisMiqdar, 0) as QaliqStock from Mallar as m " +
                                "left join(select mal_id, sum(miqdar) as SatisMiqdar from Satis_Detalli group by mal_id ) as satish on m.mal_id = satish.mal_id " +
                                "left join(select mal_id, sum(miqdar) as AlisMiqdar from Alis_Detalli group by mal_id ) as alish on m.mal_id = alish.mal_id " +
                                "where m.mal_id =" + textBox5.Text;
                SqlCommand cmd = new SqlCommand(query1, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int data = reader.GetInt32(0);
                    label12.Text = data.ToString();
                }
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string typedText = textBox1.Text;
            listView1.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Musteriler WHERE status = 0 and ad_soyad LIKE @typedText + '%'", con);
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
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secilen >= 0)
            {
                dataGridView1.Rows.RemoveAt(secilen);
                SumCalc();
            }
            else MessageBox.Show("Seçilmiş sətr yoxdur");
            secilen = -1;
        }

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
                        Boolean status = true;
                        decimal odendi = decimal.Parse(textBox7.Text);
                        if (radioButton1.Checked)
                        {
                            status = false;
                            totalSum = totalSum * -1;
                            if (odendi > 0)
                                odendi *= (-1);
                        }
                        string query = "insert into Satis(musteri_id, mebleg, odendi, tarix, status) values(@musteri, @mebleg, @odendi, @tarix, @status);SELECT SCOPE_IDENTITY();";
                        string query_detalli = "insert into Satis_Detalli(qaime_id, mal_id, miqdar, ani_qiymet, TarixD, status) values(@qaime, @mal_id, @miqdar, @ani_qiymet, @tarix2, @status)";
                        cmd = new SqlCommand(query, con, transaction);
                        cmd.Parameters.AddWithValue("@musteri", musteri_id);
                        cmd.Parameters.AddWithValue("@mebleg", totalSum);
                        cmd.Parameters.AddWithValue("@odendi", odendi);
                        cmd.Parameters.AddWithValue("@tarix", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@status", status);
                        int primaryKeyValue = Convert.ToInt32(cmd.ExecuteScalar());
                      /*  if(odendi != totalSum)
                        {                            
                            decimal res = totalSum - odendi;
                            string query4 = "update Musteriler set borc = borc + @res where musteri_id = @musteri";
                            cmd = new(query4, con, transaction);
                            *//*if (radioButton1.Checked)
                                res *= -1;*//*
                            cmd.Parameters.AddWithValue("@res", res);
                            cmd.Parameters.AddWithValue("@musteri", musteri_id);
                            cmd.ExecuteNonQuery();
                        }*/
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            int id = int.Parse(row.Cells[1].Value.ToString());
                            decimal qiymet = decimal.Parse(row.Cells[3].Value.ToString());
                            int miqdar = int.Parse(row.Cells[4].Value.ToString());
                            //"select miqdar from Mallar where mal_id =" + id;
                            string query1 = "select m.miqdar + coalesce(alish.AlisMiqdar, 0) - coalesce(satish.SatisMiqdar, 0) as QaliqStock from Mallar as m " +
                            "left join(select mal_id, sum(miqdar) as SatisMiqdar from Satis_Detalli group by mal_id ) as satish on m.mal_id = satish.mal_id " +
                            "left join(select mal_id, sum(miqdar) as AlisMiqdar from Alis_Detalli group by mal_id ) as alish on m.mal_id = alish.mal_id " +
                            "where m.mal_id ="+id;

                            cmd3 = new(query1, con, transaction);
                            object result = cmd3.ExecuteScalar();
                            if (int.Parse(result.ToString()) < miqdar)
                            {
                                DialogResult sorgu = MessageBox.Show("DİQQƏT ! \n" + id + " id nomreli məhsul stokda kifayət qədər deyil.\n Əməliyyat davam etsin ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (sorgu == DialogResult.No)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Əməliyyat icra edilmədi !");                           
                                }                                                                 
                            }
                            if (radioButton1.Checked)
                                miqdar *= -1;
                            cmd2 = new SqlCommand(query_detalli, con, transaction);
                            cmd2.Parameters.AddWithValue("@qaime", primaryKeyValue);
                            cmd2.Parameters.AddWithValue("@mal_id", id);
                            cmd2.Parameters.AddWithValue("@miqdar", miqdar);
                            cmd2.Parameters.AddWithValue("@ani_qiymet", qiymet);
                            cmd2.Parameters.AddWithValue("@tarix2", dateTimePicker1.Value);
                            cmd2.Parameters.AddWithValue("@status", status);
                            cmd2.ExecuteNonQuery();
                            /*int res = int.Parse(result.ToString()) - miqdar;
                            string query2 = "update Mallar set miqdar = "+res+" where mal_id = "+id;
                            cmd3 = new(query2, con, transaction);
                            cmd3.ExecuteNonQuery();*/
                        }
                        transaction.Commit();
                        if (status)
                            MessageBox.Show("SATIŞ uğurla icra edildi");
                        else MessageBox.Show("GERI QAYITMA uğurla icra edildi");
                        //musteri_siyahi();
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Xeta bas verdi" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        musteri_siyahi();
                    }
                    form1.dataTable2.Clear();
                    SumCalc();
                    musteri_id = -1;
                    textBox1.Clear();
                    textBox7.Text = "0,00";
                    label9.Text = "Secilmeyib";
                }
                else MessageBox.Show("Satis ucun mebleg yoxdur");
            }
            else MessageBox.Show("Musteri secimi etmemisiniz");
        }
        int musteri_id = -1;

        private void Satis_Load(object sender, EventArgs e)
        {
            mal_siyahi();
            musteri_siyahi();
            dataGridView1.DataSource = form1.dataTable2;
            dataGridView1.Columns["Mal id"].Visible = false;
            dateTimePicker1.Value= DateTime.Today;
            textBox7.Text = "0";
        }

        private void textBox7_Click(object sender, EventArgs e)
        { 
            textBox7.SelectAll();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)            
                button3.Text = "Geri qaytar";            
            else
                button3.Text = "Satış";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;            
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);                        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
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
                        panel4.Visible=false;
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
            else MessageBox.Show(textBox2.Text + " Bu kodda məhsul var ! Zəhmət olmasa unikal bir kod daxil edin");
        }

        private void clearbtn()
        {
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox6.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clearbtn();
            panel4.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        int secilen = -1;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                musteri_id = int.Parse(selectedItem.Text);
                label9.Text = selectedItem.SubItems[1].Text;
            }
        }
    }
}
