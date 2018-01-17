using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Everything4Rent.Common;
using System.Data.OleDb;

namespace Everything4Rent.Modules.User
{
    class UserModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string birthday { get; set; }
        public string picture { get; set; }
        public string userID { get; set; }
        public string userPaypal { get; set; }
        public string passwordPaypal { get; set; }
        public int rank { get; set; }

        public Boolean Login()
        {
            string query = String.Format("select * from Users where email='{0}' AND password='{1}'",this.email, this.password);
            OleDbDataReader result = DataBaseConnector.sql(query);
            result.Read();
            // first row
            //string col0 = result.GetString(0);
            //string col1 = result.GetString(1);
            //string col2 = result.GetString(2);
            // push your row to some list to create a table

            return result.HasRows;
        }

        public void SignUp()
        {
            string query = String.Format("INSERT INTO Users (UserID, email, [password], PrivateName, phone, address, birthday, paypalUser, paypalPassword) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.userID, this.email, this.password, this.firstName, this.phone, this.address, this.birthday, this.userPaypal, this.passwordPaypal);
            //string query = string.Format("INSERT INTO Users (UserID, email, password, PrivateName, phone, address, birthday, paypalUser, paypalPassword) VALUES ('"+ this.userID+"','"+ this.email+"','"+ this.password+"','"+ this.firstName+"','"+ this.phone+"','"+ this.address+"','"+ this.birthday+"','"+ this.userPaypal+"','"+ this.passwordPaypal+"')");
            OleDbDataReader result = DataBaseConnector.sql(query);
        }
    }
}
