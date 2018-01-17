using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.User
{
    public partial class LoginView : UserControl
    {
        private UserModel model = new UserModel();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            model.email = txtUserName.Text;
            model.password = txtPassword.Text;
            Boolean loginPassed = model.Login();
            this.txtPassword.Text = "";
            if (!loginPassed)
            {
                lblAuthError.Visible = true;
            }
            else
            {
                lblAuthError.Visible = false;
                Router.navigate("LOGIN", "DASHBOARD");
                Router.root.userLoggedIn = true;
                Router.root.header1.lblLogIn.Visible = false;
                Router.root.header1.lblLogOut.Visible = true;

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Router.navigate("LOGIN", "SIGNUP");
            Router.root.header1.lblLogIn.Visible = true;
            Router.root.header1.lblLogOut.Visible = false;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
        public string getUserEmail()
        {
            return model.email;
        }
    }
}
