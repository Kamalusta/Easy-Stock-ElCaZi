using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Sales_app.usercontrols
{
    public partial class Musteriler : UserControl
    {
        public Musteriler(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }
        private SqlConnection con;
        private SqlDataAdapter adapt;

        public void musteri_siyahi()
        {
            listView1.Items.Clear();
            con.Open();
            string query = "select m.musteri_id, m.ad_soyad, m.elaqe,m.unvan, m.menecer, m.kategoriya, m.borc, sum(s.mebleg) - sum(odendi) " +
                " from Musteriler m left join Satis s on m.musteri_id=s.musteri_id" +
                " where m.status=@sts " +
                " group by m.musteri_id, ad_soyad, elaqe, kategoriya, unvan, menecer, borc";
/*            string query4 = "select * from Musteriler where status = @sts";*/
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@sts",status);
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
                if (item.SubItems[7].Text == "")
                    item.SubItems[7].Text = "0";
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 0)).ToString();
                item.SubItems[7].Text = (Math.Round((decimal.Parse(item.SubItems[6].Text) + decimal.Parse(item.SubItems[7].Text)), 0)).ToString();
                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void clearbtn()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            musteri_siyahi();
            listView1.Font = new Font(listView1.Font, FontStyle.Bold);
        }

        bool status = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                status = true;
            con.Open();
            SqlCommand cmd1 = new("select ad_soyad from Musteriler where ad_soyad = @ad", con);
            cmd1.Parameters.AddWithValue("@ad", textBox1.Text);
            object result = cmd1.ExecuteScalar();
            con.Close();
            if (result == null)
            {
                decimal value1;
                if (decimal.TryParse(textBox6.Text, out value1) )
                {
                    try
                    {                                                                       
                        con.Open();
                        SqlCommand cmd = new("insert into Musteriler(ad_soyad, elaqe, unvan, menecer, kategoriya, borc, status) values(@ad, @elaqe, @unvan, @menecer, @kategoriya, @borc, @status)", con);
                        cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                        cmd.Parameters.AddWithValue("@elaqe", textBox2.Text);
                        cmd.Parameters.AddWithValue("@unvan", textBox3.Text);
                        cmd.Parameters.AddWithValue("@menecer", textBox4.Text);
                        cmd.Parameters.AddWithValue("@kategoriya", textBox5.Text);
                        cmd.Parameters.AddWithValue("@borc", value1);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Müştəri uğurla əlavə edildi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xeta bas verdi " + ex);
                    }
                    clearbtn();
                    musteri_siyahi();
                }
                else
                    MessageBox.Show("Məlumatları düzgün doldurun");
            }
            else MessageBox.Show(textBox1.Text + " Bu adda müstəri mövcuddur ! Zəhmət olmasa unikal bir ad daxil edin");
        }

        int id = -1;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                id = int.Parse(selectedItem.SubItems[0].Text);
                textBox1.Text = selectedItem.SubItems[1].Text;
                textBox2.Text = selectedItem.SubItems[2].Text;
                textBox3.Text = selectedItem.SubItems[3].Text;
                textBox4.Text = selectedItem.SubItems[4].Text;
                textBox5.Text = selectedItem.SubItems[5].Text;
                textBox6.Text = selectedItem.SubItems[6].Text;
                label11.Text = selectedItem.SubItems[1].Text;
                //musterid = 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal value1;
            if (decimal.TryParse(textBox6.Text, out value1))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("update Musteriler set ad_soyad = @ad, elaqe = @elaqe, unvan=@unvan," +
                        " menecer=@menecer, kategoriya=@kategoriya, borc=@borc where musteri_id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@elaqe", textBox2.Text);
                    cmd.Parameters.AddWithValue("@unvan", textBox3.Text);
                    cmd.Parameters.AddWithValue("@menecer", textBox4.Text);
                    cmd.Parameters.AddWithValue("@kategoriya", textBox5.Text);
                    cmd.Parameters.AddWithValue("@borc", value1);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Müştəri uğurla dəyişdirildi");
                    musteri_siyahi();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        MessageBox.Show("Zehmet olmasa unikal bir ad daxil edin");
                    }
                    else MessageBox.Show("Xəta baş verdi");
                }
                clearbtn();
                id = -1;
            }
            else
                MessageBox.Show("Məlumatları düzgün doldurun");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sorgu = MessageBox.Show("Müştərini silməyə əminsiniz ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                if (id >= 0)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new("delete from Musteriler where musteri_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müştəri uğurla silindi");                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Satış edilmiş Müştərini silə bilmərsiniz " + ex);
                    }
                    finally
                    { 
                        con.Close(); 
                        clearbtn();
                        musteri_siyahi();
                    }
                }
                else MessageBox.Show("Seçilmiş müştəri yoxdur");
            }
        }

        string add;
        private void button4_Click(object sender, EventArgs e)
        {
            add = " where m.status = @sts ";
            
            /*query = "select * from Musteriler where status = @sts ";*/
            
            listView1.Items.Clear();
            if (textBox1.Text.Length > 0)
                add += "and ad_soyad LIKE '" + textBox1.Text + "%'";
            if (textBox2.Text.Length > 0)
                add += "and elaqe LIKE '" + textBox2.Text + "%'";
            if (textBox3.Text.Length > 0)
                add += "and unvan LIKE '" + textBox3.Text + "%'";
            if (textBox4.Text.Length > 0)
                add += "and menecer LIKE '" + textBox4.Text + "%'";
            if (textBox5.Text.Length > 0)
                add += "and kategoriya LIKE '" + textBox5.Text + "%'";
            /*if (textBox6.Text.Length > 0)
                query += "and borc LIKE '" + textBox6.Text + "%'";*/

            string query = "select m.musteri_id, m.ad_soyad, m.elaqe,m.unvan, m.menecer, m.kategoriya, m.borc, sum(s.mebleg) - sum(odendi) " +
                " from Musteriler m left join Satis s on m.musteri_id=s.musteri_id " + add +
                " group by m.musteri_id, ad_soyad, elaqe, kategoriya, unvan, menecer, borc";


            string query1 = "select m.musteri_id, m.ad_soyad, m.elaqe,m.unvan, m.menecer, m.kategoriya, m.borc, sum(s.mebleg) - sum(odendi) " +
               " from Musteriler m left join Satis s on m.musteri_id=s.musteri_id" +
               " where m.status=@sts " +
               " group by m.musteri_id, ad_soyad, elaqe, kategoriya, unvan, menecer, borc";

            con.Open();
            SqlCommand cmd = new(query, con);
            //cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@sts", status);
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
                if (item.SubItems[7].Text == "")
                    item.SubItems[7].Text = "0";
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 0)).ToString();
                item.SubItems[7].Text = (Math.Round((decimal.Parse(item.SubItems[6].Text) + decimal.Parse(item.SubItems[7].Text)), 0)).ToString();

                listView1.Items.Add(item);
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearbtn();
            musteri_siyahi();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            status = true;
            musteri_siyahi();
            label1.Text = "Konturagent";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            status = false;
            musteri_siyahi();
            label1.Text = "Müştərilər";
        }

        int mebleg = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                mebleg = Int32.Parse(textBox7.Text);
                if (id > -1)
                {
                    if (mebleg != 0)
                    {
                        string query = "insert into Satis(musteri_id, mebleg, odendi, tarix, status) values(@musteri, 0, @odendi, @tarix, @status);";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@musteri", id);
                        cmd.Parameters.AddWithValue("@odendi", mebleg);
                        cmd.Parameters.AddWithValue("@tarix", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Uğurlu əməliyyat");
                        musteri_siyahi();
                        label11.Text = "Seçilməyib";
                        label11.ForeColor = Color.Maroon;
                        textBox7.Text = "0";

                    }
                    else MessageBox.Show("Məbləğ daxil edilməmişdir !");
                }
                else MessageBox.Show("Musteri secimi etmemisiniz !");
            }
            catch (Exception ex)
            {          
                MessageBox.Show("Xəta baş verdi !" + ex.Message);
            }
        }
    }
}
