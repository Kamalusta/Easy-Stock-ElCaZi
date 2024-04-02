using Sales_app.usercontrols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sales_app
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        public DataTable dataTable2;        

        public Form1()
        {
            InitializeComponent();
            dataTable2 = new DataTable();
            dataTable2.Columns.Add("Malın adı", typeof(string));
            dataTable2.Columns.Add("Mal id", typeof(string));
            dataTable2.Columns.Add("Mal kodu", typeof(string));
            dataTable2.Columns.Add("Ani Qiymət", typeof(string));
            dataTable2.Columns.Add("Miqdar", typeof(string));
            dataTable2.Columns.Add("Məbləğ", typeof(string));            
        }

        public void InitializeDatabase()
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home home_ctrl = new Home();
            addUserControl(home_ctrl);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {  
            Satis satis_ctrl = new Satis();
            addUserControl(satis_ctrl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mehsullar mehsul_ctrl = new Mehsullar();
            addUserControl(mehsul_ctrl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home_ctrl = new Home();
            addUserControl(home_ctrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteriler_ctrl = new Musteriler();
            addUserControl(musteriler_ctrl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hesabatlar hesabatlar_ctrl = new Hesabatlar();
            addUserControl(hesabatlar_ctrl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alis alis_ctrl = new Alis();
            addUserControl(alis_ctrl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Emeliyyat emeliyyat_ctrl = new Emeliyyat();
            addUserControl(emeliyyat_ctrl);                        
        }
    }
}