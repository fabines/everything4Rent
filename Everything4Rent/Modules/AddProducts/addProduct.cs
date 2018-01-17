using Everything4Rent.Common;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.AddProducts
{
    class addProduct
    {
        public string email = "";
        public string category = "";
        public string purpose = "";
        public string from = "";
        public string to = "";
        public string composition = "";
        public string condition = "";
        public string price = "";
        public string BundleID = "";
        public string deposite = "";
        public string addons = "";
        public string description = "";
        public string engine = "";
        public string color = "";
        public string prodYear = "";

        public string SubCategory = "";

        public string breed = "";
        public string age = "";
        public string sex = "";

        public string city = "";
        public string street = "";
        public string maxCapacity = "";

        public bool isBundel = false;

        public void addToDatabase()
        {
            isBundel = this.composition.Equals("Bundle");
            this.email = Router.root.loginView1.getUserEmail();
            string query = String.Format("INSERT INTO Products(email,Purpose,RentDateFrom,RentDateTo,price,addons,Deposit,Condition,Description,category,BundleID) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", this.email, this.purpose, this.from, this.to, this.price, this.addons, this.deposite, this.condition, this.description, this.category, this.BundleID);
            OleDbDataReader result = DataBaseConnector.sql(query);
            query = String.Format("Select Products.ProductID from Products where Products.email='{0}' AND Products.Purpose='{1}' AND Products.RentDateFrom='{2}' AND Products.RentDateTo='{3}' AND Products.price={4} AND Products.addons='{5}' AND Products.Deposit={6} AND Products.Condition='{7}' AND Products.Description='{8}' AND Products.category='{9}'", this.email, this.purpose, this.from, this.to, this.price, this.addons, this.deposite, this.condition, this.description, this.category);
            result = DataBaseConnector.sql(query);
            result.Read();
            string productID = result.GetValue(0).ToString();
            if (this.category.Equals("Nadlan"))
            {
                query = String.Format("INSERT INTO Nadlan(ProductID,city,street,MaxCapacity) VALUES ('{0}','{1}','{2}','{3}')", productID, (string)this.city, (string)this.street, (string)this.maxCapacity);
                result = DataBaseConnector.sql(query);
            }
            if (this.category.Equals("Vehicle"))
            {
                query = String.Format("INSERT INTO Vehicle(ProductID,engine,color,ProdYear) VALUES ('{0}','{1}','{2}','{3}')", productID, (string)this.engine, (string)this.color, this.prodYear);
                result = DataBaseConnector.sql(query);
            }
            if (this.category.Equals("SecondHand"))
            {
                query = String.Format("INSERT INTO SecondHand(ProductID,SubCategory) VALUES ('{0}','{1}')", productID, this.SubCategory);
                result = DataBaseConnector.sql(query);
            }
            if (this.category.Equals("Pets"))
            {
                query = String.Format("INSERT INTO Pets(ProductID,breed,age,sex) VALUES ('{0}','{1}','{2}','{3}')", productID, this.breed, this.age, this.sex);
                result = DataBaseConnector.sql(query);
            }
        }


    }
}
