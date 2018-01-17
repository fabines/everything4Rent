using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Everything4Rent.Common;
using System.Data;
using Everything4Rent.Modules.RentListings;
using Everything4Rent.Modules.Product;
using System.Windows.Forms;

namespace Everything4Rent.Modules.DashBoard
{
    class DashboardModel
    {
        public string productId;
        public string email = "";
        public string category;
        public string purpose;
        public string from;
        public string to;
        public string composition;
        public string condition;
        public string price;
        public string addons;
        public string deposite;
        public string description;
        public List<ProductListingModel> productsToDisplay;



        //Nadlan
        public string city;
        public string street;
        public string capacity;

        //Pets
        public string breed;
        public string age;
        public string sex;

        //Second hand
        public string subCategory;

        //Vehicle
        public string engine;
        public string color;
        public string prodYear;

        public void getProducts()
        {
            /*
           * SELECT *
              FROM Products
                  where UserId<>'245875698' AND type='Nadlan' AND RentDateFrom > #3/1/1996# AND RentDateTo < #3/1/2019#  AND Condition='New' AND Bundle=true AND Purpose='loan'
           */

            string query = "Select * From Products where email='" + Router.root.loginView1.getUserEmail() + "'";
            OleDbDataReader result = DataBaseConnector.sql(query);
            productsToDisplay = new List<ProductListingModel>();
            if (!result.Read())
            {
                MessageBox.Show("no Results found please try again.");
            }
            do
            {
                
                    //string value=(string)result.GetValue(0).ToString();
                    email = result.GetString(0);
                    productId = result.GetValue(1).ToString();
                    purpose = result.GetValue(2).ToString();
                    from = result.GetValue(3).ToString();
                    to = result.GetString(4);
                    price = result.GetValue(5).ToString();
                    addons = result.GetString(6);
                    deposite = result.GetValue(7).ToString();
                    condition = result.GetString(8);
                    description = result.GetString(9);
                    category = result.GetString(10);
                    composition = result.GetValue(11).ToString();

                    ProductListingModel product = new ProductListingModel(productId, description, composition, condition, category, purpose, from, to, price, addons);
                    productsToDisplay.Add(product);
                
            }
            while (result.Read());

            

            Router.root.adsPage.populateListingView(productsToDisplay, this.category);

            Router.navigate("DASHBOARD", "SHOWADS");

        }
    }
}