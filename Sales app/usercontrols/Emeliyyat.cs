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
    public partial class Emeliyyat : UserControl
    {  
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private DataTable dataTable;
        public Emeliyyat()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        public void InitializeDatabase()
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }

        private void DataGetir()
        {

        }
        private void Emeliyyat_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            //button1.ForeColor = Color.Red;
            
            bool status = true;
            string kassamedaxil = " ";
            if (radioButton1.Checked)
            {
                status = false;
                label10.Visible = true;
            } 
            else label10.Visible = false;
            if (button3.ForeColor == Color.Red)
            {
                status = false;
                kassamedaxil = " and s.mebleg is NULL ";              
            }
            string query = "select s.qaime_id, m.ad_soyad, s.mebleg, s.odendi, s.tarix " +
                "from Satis s join Musteriler m on s.musteri_id=m.musteri_id " +
                "where s.status=@status "+kassamedaxil+" order by s.tarix desc, s.qaime_id desc";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", status);

            con.Open();
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
                item.SubItems.Add(Math.Round(decimal.Parse(dr[2].ToString()), 2).ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[3].ToString()), 2).ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy"));

                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            radioButton1.Checked = !radioButton1.Checked;
            Emeliyyat_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            listView1.Items.Clear();
            listView2.Items.Clear();
            button2.ForeColor = Color.Red;
            button1.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            label4.Text = "Mədaxil Qaimələr";
            label10.Visible = false;

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
                item.SubItems.Add(Math.Round(decimal.Parse(dr[2].ToString()), 2).ToString());
                item.SubItems.Add(Math.Round(decimal.Parse(dr[3].ToString()), 2).ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[4].ToString()).ToString("dd.MM.yyyy"));

                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emeliyyat_Load(sender, e);
            radioButton1.Visible=true;
            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            label4.Text = "Məxaric Qaimələr";
        }
        string selected;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            listView2.Items.Clear();
            label3.Text = "0";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selected = selectedItem.SubItems[0].Text;
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            label3.Text = selected;
            listView2.Items.Clear();
            string query = "select m.ad, m.kod, m.olke, sd.miqdar, sd.ani_qiymet, sd.id " +
            "from Satis_Detalli sd join Mallar m on sd.mal_id=m.mal_id where qaime_id =" + selected;
            if (!radioButton1.Visible)
            {
                query = "select m.ad, m.kod, m.olke, sd.miqdar, sd.ani_qiymet, sd.id " +
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
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 2)).ToString();
                listView2.Items.Add(item);
            }           
            con.Close();
        }
        string satis_dt_id;


        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            listView1.Items.Clear();
            listView2.Items.Clear();
            button3.ForeColor = Color.Red;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            label4.Text = "Kassa Mədaxil";
            label10.Visible = false;
            Emeliyyat_Load(sender, e);

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            panel1.Visible = false;

        }

        decimal mebleg = 0;
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            textBox2.Enabled = false;
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                textBox1.Text = selectedItem.SubItems[0].Text;
                textBox2.Text = selectedItem.SubItems[1].Text;
                textBox3.Text = selectedItem.SubItems[2].Text;
                textBox4.Text = selectedItem.SubItems[3].Text;
                int prc = (int)Math.Abs(decimal.Parse(selectedItem.SubItems[4].Text));
                textBox5.Text = prc.ToString();
                satis_dt_id = selectedItem.SubItems[5].Text;
                mebleg = prc * Int32.Parse(selectedItem.SubItems[3].Text);
            }
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
            panel1.Visible=false;
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
                    cmd.ExecuteNonQuery ();
                    SqlCommand cmd2 = new SqlCommand(query_satis_up, con, transaction);
                    cmd2.Parameters.AddWithValue("@mebleg", mebleg);
                    cmd2.Parameters.AddWithValue("@qaime", selected);
                    cmd2.ExecuteNonQuery ();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
