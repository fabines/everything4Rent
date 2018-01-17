using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Template
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
            lblLogOut.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Router.root.userLoggedIn)
            {
                Router.navigate("HEADER", "USER");
            }
            else 
            {
                Router.navigate("HEADER", "LOGIN");
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Router.root.userLoggedIn = false;
            lblLogOut.Visible = false;
            lblLogIn.Visible = true;
            Router.navigate("HEADER", "LOGIN");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Router.navigate("HEADER", "HOMEPAGE");
        }
    }
}
