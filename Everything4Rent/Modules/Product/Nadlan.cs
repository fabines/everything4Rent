using Everything4Rent.Modules.RentListings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.Product
{
    class Nadlan : ProductListingModel
    {
        public string city;
        public string street;
        public string capacity;


        public Nadlan(string productId, string description, string composition, string condition, string category, string purpose, string dateFrom, string dateTo, string city, string street, string maxCapacity, string price, string addons)
            : base(productId, description, composition, condition, category, purpose, dateFrom, dateTo, price, addons)
        {
            
            this.city = city;
            this.street = street;
            this.capacity = maxCapacity;
        }
    }
}
