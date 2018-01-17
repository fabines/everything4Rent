using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.DashBoard
{
    public partial class ActionBar : UserControl
    {
        public ActionBar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DashboardModel dbm = new DashboardModel();
            dbm.getProducts();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashboardModel dbm = new DashboardModel();
            //dbm.getRents();
            Router.navigate("DASHBOARD", "SHOWADS");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Router.navigate("DASHBOARD", "ADDPRODUCT");
        }
    }
}
