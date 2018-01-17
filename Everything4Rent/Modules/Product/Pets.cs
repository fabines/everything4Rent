using Everything4Rent.Modules.RentListings;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.Product
{
    class Pets :ProductListingModel
    
    {
        public string breed;
        public string age;
        public string sex;
        public Pets(string productId, string description, string composition, string condition, string category, string purpose, string dateFrom, string dateTo, string sex, string age, string breed, string price, string addons)
            : base(productId, description, composition, condition, category, purpose, dateFrom, dateTo, price, addons)
        {
            this.breed = breed;
            this.age = age;
            this.sex = sex;
        }
    }
}
