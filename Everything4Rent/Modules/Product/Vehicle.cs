using Everything4Rent.Modules.RentListings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.Product
{
    class Vehicle :ProductListingModel
    {
        public string engine;
        public string color;
        public string prodYear;

        public Vehicle(string productId, string description, string composition, string condition, string category, string purpose, string dateFrom, string dateTo, string engine, string color, string prodYear, string price, string addons)
            : base(productId, description, composition, condition, category, purpose, dateFrom, dateTo, price, addons)
        {
            this.engine = engine;
            this.color = color;
            this.prodYear = prodYear;
        }
    }
}
