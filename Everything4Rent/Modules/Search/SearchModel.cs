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

namespace Everything4Rent.Modules.Search
{
    class SearchModel
    {
        public string productId;
        public string email ="";
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

        public void doSearch()
        {
            /*
             * SELECT *
                FROM Products
                    where UserId<>'245875698' AND type='Nadlan' AND RentDateFrom > #3/1/1996# AND RentDateTo < #3/1/2019#  AND Condition='New' AND Bundle=true AND Purpose='loan'
             */
            string query = "Select * From Products INNER JOIN " +this.category+" ON Products.ProductID="+this.category+".ProductID Where Products.category='" + this.category + "' ";
            query += "AND Products.RentDateFrom <= #" + this.from + "# ";
            query += "AND Products.RentDateTo >= #" + this.to + "# ";
            /*if (this.userID.Length > 0)
            {
                query += "AND UserId<>'" + this.userID + "' ";
            }*/
            if (this.purpose != null)
            {
                query += "AND Products.Purpose='" + this.purpose + "' ";
            }
            if (this.condition != null)
            {
                query += "AND Products.Condition='" + this.condition + "' ";
            }
            /*
            if (this.composition != null)
            {
                Boolean isBundel = this.composition.Equals("Bundle");
                query += "AND Products.Bundle=" + isBundel + " ";
            }
            */
            OleDbDataReader result = DataBaseConnector.sql(query);                // temp for example

            if (!result.HasRows)
            {
                MessageBox.Show("No Results Found! \n Please Try again");
                return;
            }


            productsToDisplay= new List<ProductListingModel>();
            result.Read();
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
                composition = result.GetValue(12).ToString();
                // breed = result.GetValue(13).ToString();
                // age = result.GetValue(14).ToString();
                // sex = result.GetString(15);
                ProductListingModel product = new ProductListingModel(productId, description, composition, condition, category, purpose, from, to, price, addons);
                Dictionary<string, string> props = new Dictionary<string, string>();
                populateProps(result, props);
                product.props = props;


                productsToDisplay.Add(product);
                
            }
            while (result.Read());
              

            /*
            else if (this.category.Equals("Nadlan"))
            {
                productsToDisplay = new List<ProductListingModel>();
                result.Read();
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
                    composition = result.GetValue(12).ToString();
                    breed = result.GetValue(13).ToString();
                    age = result.GetValue(14).ToString();
                    sex = result.GetString(15);
                    ProductListingModel pets = new Pets(productId, description, composition, condition, category, purpose, from, to, sex, age, breed);
                    productsToDisplay.Add(pets);
                }
                while (result.Read());
            }
            else if (this.category.Equals("Vehicle"))
            {
                productsToDisplay = new List<ProductListingModel>();
                result.Read();
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
                    composition = result.GetValue(12).ToString();
                    breed = result.GetValue(13).ToString();
                    age = result.GetValue(14).ToString();
                    sex = result.GetString(15);
                    ProductListingModel pets = new Pets(productId, description, composition, condition, category, purpose, from, to, sex, age, breed);
                    productsToDisplay.Add(pets);
                }
                while (result.Read());
            }
            else if (this.category.Equals("SecondHand"))
            {
                productsToDisplay = new List<ProductListingModel>();
                result.Read();
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
                    composition = result.GetValue(12).ToString();
                    breed = result.GetValue(13).ToString();
                    age = result.GetValue(14).ToString();
                    sex = result.GetString(15);
                    ProductListingModel pets = new Pets(productId, description, composition, condition, category, purpose, from, to, sex, age, breed);
                    productsToDisplay.Add(pets);
                }
                while (result.Read());
            }
*/
            // 1) go back to the point where you had the filtered product list

            // 2) once you get the OleDbDataReader result for products table you need to map it into objects


            // 3) meanwhile we'll use a mockup:

        /*    // our goal is to create a list of products models
            ProductListingModel productMock1 = new ProductListingModel("PET1", this.composition, this.condition, this.category, this.purpose, this.from, this.to);
            ProductListingModel productMock2 = new ProductListingModel("PET2", this.composition, this.condition, this.category, this.purpose, this.from, this.to);
            ProductListingModel productMock3 = new ProductListingModel("PET3", this.composition, this.condition, this.category, this.purpose, this.from, this.to);
            ProductListingModel productMock4 = new ProductListingModel("PET4", this.composition, this.condition, this.category, this.purpose, this.from, this.to);
            */
            // do it with a for loop :)
           /* 
            productsToDisplay.Add((ProductListingModel)pets);
            productsToDisplay.Add(productMock2);
            productsToDisplay.Add(productMock3);
            productsToDisplay.Add(productMock4);
            */
            Router.root.listingView.cleanPanel();
            Router.root.listingView.populateListingView(productsToDisplay, this.category);

            Router.navigate("SEARCH", "RENT_LISTING");



           
            /*DataTable table= result.GetSchemaTable();
            while (result.Read())
            {
                string companyCode = reader.GetValue(0).ToString();
                string agentId = reader.GetString(1);
                string firstName = reader.GetString(2);
                string lastName = reader.GetString(3);
                string nameSuffix = reader.GetString(4);
                string corporateName = reader.GetString(5);
                string entityType = reader.GetString(6);
                string obfSSN = reader.GetString(7);
                string obfFEIN = reader.GetString(8);
                string dummyIndicator = reader.GetString(9);
                // Insert code to process data.
            }*/
        }

        private void populateProps(OleDbDataReader result, Dictionary<string, string> props)
        {
            if(this.category.Equals("Nadlan"))
            {
                props.Add("city", result.GetString(13));
                props.Add("street", result.GetString(14));
                props.Add("max_capacity", result.GetString(15));
            }
            if (this.category.Equals("Pets"))
            {
                props.Add("breed", result.GetString(13));
                props.Add("age", result.GetString(14));
                props.Add("sex", result.GetString(15));
            }
            if (this.category.Equals("SecondHand"))
            {
                props.Add("sub_category", result.GetString(13));
            }
            if (this.category.Equals("Vehicle"))
            {
                props.Add("engine", result.GetString(13));
                props.Add("color", result.GetString(14));
                props.Add("prod_year", result.GetString(15));
            }
        }
    }
}
