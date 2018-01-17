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
    public partial class SignUpView : UserControl
    {
        private UserModel model = new UserModel();

        public SignUpView()
        {
            InitializeComponent();
        }

        private bool vaild_details()
        {
            bool ans = true;
            ans = (checkName() && ans);
            ans = (checkUserID() && ans);
            ans = (checkEmail() && ans);
            ans = (checkPaypalName() && ans);
            ans = (checkPhone() && ans);
            ans = (checkPassword() && ans);
            ans = (checkPaypalPassword() && ans);
            ans = (checkAddress() && ans);
            return ans;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ddlAddress.Text = "";
            addressError.Visible = false;
            ddlBirthday.Text = "";
            ddlEmail.Text = "";
            emailError.Visible = false;
            ddlUserID.Text = "";
            userIDError.Visible = false;
            ddlName.Text = "";
            nameError.Visible = false;
            ddlPassword.Text = "";
            passwordError.Visible = false;
            ddlPaypalPassword.Text = "";
            passwordPaypalError.Visible = false;
            ddlPaypalUser.Text = "";
            userPaypalError.Visible = false;
            ddlPhone.Text = "";
            phoneError.Visible = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!vaild_details())
                MessageBox.Show("wrong details... please change it");
            else
            {
                model.address = ddlAddress.Text;
                model.birthday = ddlBirthday.Value.ToShortDateString();
                model.email = ddlEmail.Text;
                model.firstName = ddlName.Text;
                model.password = ddlPassword.Text;
                model.phone = ddlPhone.Text;
                model.userID = ddlUserID.Text;
                model.userPaypal = ddlPaypalUser.Text;
                model.passwordPaypal = ddlPaypalPassword.Text;
                model.SignUp();
                Router.navigate("SIGNUP", "LOGIN");
                Router.root.header1.lblLogIn.Visible = true;
                Router.root.header1.lblLogOut.Visible = false;
            }
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {

        }


        private bool checkName()
        {
            string Name = ddlName.Text;
            if (Name.Length == 0 || Name.Length == 1)
            {
                nameError.Visible = true;
                nameError.Text = "you must enter your first name";
                return false;
            }
            else if (!ContainsOnlyLetters(Name))
            {
                nameError.Visible = true;
                nameError.Text = "your  name cannot contain chars that are not letters";
                return false;
            }
            else
            {
                nameError.Visible = false;
                return true;
            }
        }

        private bool checkEmail()
        {
            string email = ddlEmail.Text;
            if (!email.Contains("@"))
            {
                emailError.Visible = true;
                emailError.Text = "invalid email";
                return false;
            }
            else
            {
                string[] s = email.Split('@');
                string beforeSh = s[0];
                string afterSh = s[1];
                if (beforeSh.Length == 0 || afterSh.Length == 0 || !afterSh.Contains("."))
                {
                    emailError.Visible = true;
                    emailError.Text = "invalid email";
                    return false;
                }
                else
                {
                    emailError.Visible = false;
                    return true;
                }
            }
        }

        private bool checkPhone()
        {
            string phone = ddlPhone.Text;
            if (!onlyDigits(phone) || phone.Length != 10)
            {
                phoneError.Visible = true;
                phoneError.Text = "must contain 10 digits";
                return false;
            }
            else
            {
                phoneError.Visible = false;
                return true;
            }
        }

        private bool checkUserID()
        {
            string userID = ddlUserID.Text;
            if (!onlyDigits(userID) || userID.Length != 9)
            {
                userIDError.Visible = true;
                userIDError.Text = "must contain 9 digits";
                return false;
            }
            else
            {
                userIDError.Visible = false;
                return true;
            }
        }

        private bool checkPassword()
        {
            int counter = 0;
            bool hasCapitalLetter = false;
            bool hasDigit = false;
            bool hasletter = false;
            string password = ddlPassword.Text;
            foreach (var c in password)
            {
                if (c >= '0' && c <= '9' && !hasDigit) { hasDigit = true; counter++; }
                if (c >= 'A' && c <= 'Z' && !hasCapitalLetter) { hasCapitalLetter = true; counter++; }
                if (c >= 'a' && c <= 'z' && !hasletter) { hasletter = true; counter++; }
            }
            if (password.Length < 8)
            {
                passwordError.Visible = true;
                passwordError.Text = "must contain at least 8 chars";
                return false;
            }
            else if (counter != 3 || password.Length == 0)
            {
                passwordError.Visible = true;
                if (!hasCapitalLetter) { passwordError.Text = "capital letter required"; }
                else if (!hasDigit) { passwordError.Text = "at least one digit required"; }
                else if (!hasletter) { passwordError.Text = "at least one small letter required"; }
                return false;
            }
            else
            {
                passwordError.Visible = false;
                return true;
            }
        }

        private bool checkPaypalName()
        {
            string userPaypal = ddlPaypalUser.Text;
            if (userPaypal.Length == 0 || userPaypal.Length == 1)
            {
                userPaypalError.Visible = true;
                userPaypalError.Text = "you must enter your password in paypal";
                return false;
            }
            else
            {
                userPaypalError.Visible = false;
                return true;
            }
        }

        private bool checkPaypalPassword()
        {
            string passwordPaypal = ddlPaypalPassword.Text;
            if (passwordPaypal.Length == 0 || passwordPaypal.Length == 1)
            {
                passwordPaypalError.Visible = true;
                passwordPaypalError.Text = "you must enter your password in paypal";
                return false;
            }
            else
            {
                passwordPaypalError.Visible = false;
                return true;
            }
        }

        private bool checkAddress()
        {
            string address = ddlAddress.Text;
            if (address.Length == 0 || address.Length == 1)
            {
                addressError.Visible = true;
                addressError.Text = "you must enter your address";
                return false;
            }
            else
            {
                addressError.Visible = false;
                return true;
            }
        }

        private bool onlyDigits(string age)
        {
            foreach (var c in age)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ContainsOnlyLetters(string fName)
        {
            foreach (var c in fName)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= 'א' && c <= 'ת')))
                {
                    return false;
                }
            }
            return true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
