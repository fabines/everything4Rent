using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Modules.Product;
using Everything4Rent.Modules.RentItem;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.RentListings
{
    public partial class ListingView : UserControl
    {
        // private List<ProductListingModel> productsToDisplay;
        public ListingView()
        {
            InitializeComponent();
            //this.productsToDisplay = new List<ProductListingModel>();
        }

        private void ListingView_Load(object sender, EventArgs e)
        {

        }

        internal void populateListingView(List<ProductListingModel> productsToDisplay, string category)
        {
            this.productsToDisplay = productsToDisplay;
            int index = 0;
            foreach (ProductListingModel product in productsToDisplay)
            {
                ListItem item = new ListItem();
                // item.Location = new System.Drawing.Point(3, 3);
                item.Name = index.ToString();
                item.Size = new System.Drawing.Size(736, 132);
                item.lblDesc.Text = product.description;
                item.lblCondi.Text = product.condition;
                item.lblFrom.Text = product.dateFrom;
                item.lblTo.Text = product.dateTo;
                item.lblPric.Text = product.price;
                item.lblPurpo.Text = product.purpose;
                item.lblAddons.Text = product.addons;
                item.Click += (s, e) =>
                {
                    this.populateFields(product);
                    Router.navigate("RENT_LISTING", "PRODUCT_VIEW");
                };
                flpListingPanel.Controls.Add(item);

            }
        }

        private void populateFields(ProductListingModel product)
        {
            if (product.category.Equals("Nadlan"))
            {
                Router.root.productItem.nadlanProduct1.lblAddress.Text = product.props["city"] + " , " + product.props["street"];
                Router.root.productItem.nadlanProduct1.lblCapacity.Text = product.props["max_capacity"];
                Router.root.productItem.nadlanProduct1.lblDesc.Text = product.description;
                Router.root.productItem.nadlanProduct1.Visible = true;
            }
            if (product.category.Equals("SecondHand"))
            {
                Router.root.productItem.secondHandProducts1.lblSecondHand.Text = product.props["sub_category"];
                Router.root.productItem.secondHandProducts1.Visible = true;
            }
            if (product.category.Equals("Vehicle"))
            {
                Router.root.productItem.vehicleProducts1.lblEngine.Text = product.props["engine"];
                Router.root.productItem.vehicleProducts1.lblColor.Text = product.props["color"];
                Router.root.productItem.vehicleProducts1.lblProdYear.Text = product.props["prod_year"];
                Router.root.productItem.vehicleProducts1.Visible = true;
            }
            if (product.category.Equals("Pets"))
            {
                Router.root.productItem.petsProducts1.lblAge.Text = product.props["age"];
                Router.root.productItem.petsProducts1.lblBread.Text = product.props["breed"];
                Router.root.productItem.petsProducts1.lblSex.Text = product.props["sex"];
                Router.root.productItem.petsProducts1.Visible = true;
            }
        }




        private void flpListingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        internal void cleanPanel()
        {
            flpListingPanel.Controls.Clear();
        }
    }
}
