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

namespace Sales_app.usercontrols
{
    public partial class Home : UserControl
    {
        public SqlConnection conAnbar;
        Satis satis_ctrl;
        Mehsullar mehsul_ctrl;
        Musteriler musteriler_ctrl;
        Hesabatlar hesabatlar_ctrl;
        Alis alis_ctrl;
        Emeliyyat emeliyyat_ctrl;
        HesabatMusteri hesabatMusteri;

        public Home(SqlConnection conn)
        {
            InitializeComponent();
            conAnbar = conn;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            satis_ctrl = new Satis(conAnbar);
            mehsul_ctrl = new Mehsullar(conAnbar);
            musteriler_ctrl = new Musteriler(conAnbar);
           
            alis_ctrl = new Alis(conAnbar);
            
            
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
            addUserControl(satis_ctrl);
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            addUserControl(mehsul_ctrl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(musteriler_ctrl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesabatlar_ctrl = new Hesabatlar(conAnbar);
            addUserControl(hesabatlar_ctrl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addUserControl(alis_ctrl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            emeliyyat_ctrl = new Emeliyyat(conAnbar);
            addUserControl(emeliyyat_ctrl);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hesabatMusteri = new HesabatMusteri(conAnbar);
            addUserControl(hesabatMusteri);
        }        
    }
}
