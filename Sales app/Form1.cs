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

        public SqlConnection conAnbar;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            this.MaximumSize = primaryScreen.Bounds.Size;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar;Integrated Security=True;";
            conAnbar = new SqlConnection(connectionString);
            button10.BackColor = Color.LightGray;
            button9.BackColor = Color.White;

            Home home = new Home(conAnbar);
            addUserControl(home);
            Screen primaryScreen = Screen.PrimaryScreen;
            this.MaximumSize = primaryScreen.Bounds.Size;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Anbar1;Integrated Security=True;";
            conAnbar = new SqlConnection(connectionString);
            button9.BackColor = Color.LightGray;
            button10.BackColor = Color.White;

            Home home = new Home(conAnbar);
            addUserControl(home);
        }
    }
}