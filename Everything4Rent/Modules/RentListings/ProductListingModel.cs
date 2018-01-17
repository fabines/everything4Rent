using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Everything4Rent.Modules.RentListings
{
    class ProductListingModel
    {
        //product
        public string productId;
        public string description;
        public string composition;
        public string condition;
        public string category;
        public string purpose;
        public string dateFrom;
        public string dateTo;
        public string price;
        public string addons;

        public ProductListingModel(string productId, string description, string composition, string condition, string category, string purpose, string dateFrom, string dateTo, string price, string addons)
        {
            this.productId = productId;
            this.description = description;
            this.composition = composition;
            this.condition = condition;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.category = category;
            this.purpose = purpose;
            this.price = price;
            this.addons = addons;
        }


        public Dictionary<string, string> props { get; set; }
    }
}
