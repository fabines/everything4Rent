using Everything4Rent.Modules.RentListings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.Product
{
    class SecondHand : ProductListingModel
    {
        public string subCategory;
        public SecondHand(string productId, string description, string composition, string condition, string category, string purpose, string dateFrom, string dateTo, string subCategory, string price, string addons)
            : base(productId, description, composition, condition, category, purpose, dateFrom, dateTo, price, addons)
        {
            this.subCategory = subCategory;
        }
    }
}
