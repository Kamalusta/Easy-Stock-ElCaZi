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
    public partial class Mehsullar : UserControl
    {
        public Mehsullar()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private SqlConnection con;
        private SqlDataAdapter adapt;

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";
            con = new SqlConnection(connectionString);
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
                {
                    item.SubItems.Add(row[i].ToString());
                }
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 2)).ToString();
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 2)).ToString();

                listView1.Items.Add(item);
            }
            con.Close();
        }
        private void Mehsullar_Load(object sender, EventArgs e)
        {
            mal_siyahi();
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new("select kod from Mallar where kod = @kod", con);
            cmd1.Parameters.AddWithValue("@kod", textBox2.Text);
            object result = cmd1.ExecuteScalar();
            con.Close();
            if (result == null)
            {
                decimal value1, value2;
                int value3;
                if (decimal.TryParse(textBox4.Text, out value1) && decimal.TryParse(textBox5.Text, out value2) && int.TryParse(textBox6.Text, out value3))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new("insert into Mallar(ad, kod, olke, alis, satis, miqdar) values(@ad, @kod, @olke, @alis, @satis, @miqdar)", con);
                        cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                        cmd.Parameters.AddWithValue("@kod", textBox2.Text);
                        cmd.Parameters.AddWithValue("@olke", textBox3.Text);
                        cmd.Parameters.AddWithValue("@alis", value1);
                        cmd.Parameters.AddWithValue("@satis", value2);
                        cmd.Parameters.AddWithValue("@miqdar", value3);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Məhsul uğurla əlavə edildi");
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
                decimal value1, value2;
                int value3;
                if (decimal.TryParse(textBox4.Text, out value1) && decimal.TryParse(textBox5.Text, out value2) && int.TryParse(textBox6.Text, out value3))
                {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("update Mallar set ad = @ad, kod = @kod, olke=@olke, alis=@alis, satis=@satis, miqdar=@miqdar " +
                                            "where mal_id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@kod", textBox2.Text);
                    cmd.Parameters.AddWithValue("@olke", textBox3.Text);
                    cmd.Parameters.AddWithValue("@alis", value1);
                    cmd.Parameters.AddWithValue("@satis", value2);
                    cmd.Parameters.AddWithValue("@miqdar", value3);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Məhsul uğurla dəyişdirildi");
                    mal_siyahi();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        MessageBox.Show("Zehmet olmasa unikal kod daxil edin");
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
            DialogResult sorgu = MessageBox.Show("Məhsulu silməyə əminsiniz ?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sorgu == DialogResult.Yes)
            {
                if (id >= 0)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new("delete from Mallar where mal_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Mehsul uğurla silindi");                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Satış edilmiş məhsulu silə bilmərsiniz " +ex);
                    }
                    finally
                    { 
                      con.Close(); 
                      clearbtn();
                      mal_siyahi();
                    }
                }
                else MessageBox.Show("Secilmis mehsul yoxdur");
            }
        }
        string v1 = "";
        string query;
        private void button4_Click(object sender, EventArgs e)
        {
            //clearbtn();
            listView1.Items.Clear();
            if (textBox1.Text.Length > 0)
                v1 = "and ad LIKE '" +textBox1.Text + "%'";           
            if (textBox2.Text.Length > 0)
                v1 = "and kod LIKE '" + textBox2.Text + "%'";
            if (textBox3.Text.Length > 0)
                v1 = "and olke LIKE '" + textBox3.Text + "%'";
            if (textBox4.Text.Length > 0)
                v1 = "and alis LIKE '" + textBox4.Text + "%'";
            if (textBox5.Text.Length > 0)
                v1 = "and satis LIKE '" + textBox5.Text + "%'";
            if (textBox6.Text.Length > 0)
                v1 = "and miqdar LIKE '" + textBox6.Text + "%'";

            query = "select * from Mallar where mal_id > -1 " + v1;

            con.Open();
            SqlCommand cmd = new(query, con);
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
            v1 = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearbtn();
        }
    }
}
