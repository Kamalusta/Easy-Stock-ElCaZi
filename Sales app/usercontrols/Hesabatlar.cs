using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Sales_app.usercontrols
{
    public partial class Hesabatlar : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private DataTable dataTable;
        public Hesabatlar()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        public void InitializeDatabase()
        {
            string connectionString = "Data Source =.; Initial Catalog = Anbar; Integrated Security = True; ";
            con = new SqlConnection(connectionString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Ad").Width= 60;
            listView1.Columns.Add("Kod").Width = 60;
            listView1.Columns.Add("Ölkə").Width = 80;
            listView1.Columns.Add("Anbar").Width = 60;
            listView1.Columns.Add("Alınıb").Width = 60;
            listView1.Columns.Add("Satılıb").Width = 60;
            listView1.Columns.Add("Qiymət").Width = 100;
            listView1.Columns.Add("Məbləğ").Width = 120;
            listView1.Columns.Add("Miqdar").Width = 60;
            //label2.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            
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
            SqlCommand cmd = new SqlCommand(uHesabat,con);          
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                    item.SubItems.Add(row[i].ToString());
                item.SubItems[6].Text = (Math.Round(decimal.Parse(item.SubItems[6].Text), 2)).ToString();
                //item.SubItems[7].Text = (Math.Round(decimal.Parse(item.SubItems[7].Text), 2)).ToString();
                if (decimal.TryParse(item.SubItems[7].Text, out decimal parsedValue))
                {
                    item.SubItems[7].Text = Math.Round(parsedValue, 2).ToString();
                }
                listView1.Items.Add(item);
            }
            con.Close();
            umumihesab(8,7,4,5);
        }
        private void umumihesab(int a,int b,int c, int d)
        {
            int sum = 0;
            decimal mebl = 0;
            int al = 0;
            int sat = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                decimal value = 0;
                int value2 = 0;
                if (int.TryParse(item.SubItems[a].Text, out value2))
                    sum += value2;
                if (decimal.TryParse(item.SubItems[b].Text, out value))
                    mebl += value;
                if (int.TryParse(item.SubItems[c].Text, out value2))
                    al += value2;
                if (int.TryParse(item.SubItems[d].Text, out value2))
                    sat += value2;
            }
            label5.Text = sum.ToString()+" əd.";
            label8.Text = mebl.ToString()+" AZN";
            label11.Text = al.ToString()+" əd.";
            label12.Text = sat.ToString()+" əd.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Ad").Width = 60;
            listView1.Columns.Add("Kod").Width = 60;
            listView1.Columns.Add("Ölkə").Width = 80;
            listView1.Columns.Add("Satılıb").Width = 60;
            listView1.Columns.Add("Qiymət").Width = 100;
            listView1.Columns.Add("Məbləğ").Width = 120;
            listView1.Columns.Add("Status").Width = 100;
            string finder = "";
            string query = " select m.ad, m.kod, m.olke, sum(sd.miqdar) as satisMiqdar, m.satis as qiymet,(sum(sd.miqdar) * m.satis) as mebleg, sd.status " +
                "from Satis_Detalli as sd left join Mallar as m on sd.mal_id = m.mal_id where sd.TarixD between @date1 and @date2 group by m.ad, m.kod, m.olke,m.satis,sd.status " +
                "having m.kod is not null "+finder+" order by m.kod";
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
                item.SubItems[4].Text = (Math.Round(decimal.Parse(item.SubItems[4].Text), 2)).ToString();
                item.SubItems[5].Text = (Math.Round(decimal.Parse(item.SubItems[5].Text), 2)).ToString();
                if (item.SubItems[6].Text == "True")
                    item.SubItems[6].Text = "";
                else
                {
                    item.SubItems[6].ForeColor = Color.Blue;
                    item.SubItems[6].Text = "Geri qayıtma";                    
                }
                listView1.Items.Add(item);
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
            label8.Text = mebl.ToString()+" AZN";
            label12.Text = sat.ToString()+" əd.";
            label11.Text = "0";
            label5.Text = "0";
        }
        string ad;
        string kod;
        string olke;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            kod = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            olke = textBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hesabatlar_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
