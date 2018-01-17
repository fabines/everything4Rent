using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Everything4Rent.Common;
using Everything4Rent.Modules.Product;

namespace Everything4Rent.Modules.Product
{
    class ProductModel
    {
       public long productID;

        /*public Nadlan getNadlanProduct() {
            string query = String.Format("select * from Nadlan where ProductID='{0}'", this.productID);
            OleDbDataReader result = DataBaseConnector.sql(query);
            result.Read();
            string city = result.GetString(1);
            string street = result.GetString(2);
            string site = result.GetString(3);
            int capacity = result.GetInt32(4);
            return new Nadlan(city, street, site, capacity);

        }*/



        /*public Pets[] getPetsToSearch(OleDbDataReader reader)
        {
              while (reader.Read())
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
            }
            reader.Close();
        }
        }*/
    }
}
