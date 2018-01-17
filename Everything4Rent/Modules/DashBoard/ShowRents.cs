using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Modules.RentListings;

namespace Everything4Rent.Modules.DashBoard
{
    public partial class ShowRents : UserControl
    {
        public ShowRents()
        {
            InitializeComponent();
        }
        private void flpListingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        internal void populateListingView(List<ProductListingModel> productsToDisplay, string category)
        {
            this.productsToDisplay = productsToDisplay;
            int index = 0;
            foreach (ProductListingModel product in productsToDisplay)
            {
                ListItem item = new ListItem();
                item.Location = new System.Drawing.Point(3, 3);
                item.Name = "lstItem" + index.ToString();
                item.Size = new System.Drawing.Size(736, 132);
                item.lblDesc.Text = product.description;
                this.flpListingPanel.Controls.Add(item);
            }


            /*else if(category.Equals("Pets"))
            {
                foreach (ProductListingModel product in productsToDisplay)
                {
                    PetsProducts item = new PetsProducts();
                    // item.Location = new System.Drawing.Point(3, 3);
                    item.Name = "lstItem" + index.ToString();
                    item.Size = new System.Drawing.Size(736, 132);
                    item.lblDescription.Text = product.description;
                    flpListingPanel.Controls.Add(item);
                }
            }
            else if (category.Equals("SecondHand"))
            {
                foreach (ProductListingModel product in productsToDisplay)
                {
                    NadlanProduct item = new NadlanProduct();
                    // item.Location = new System.Drawing.Point(3, 3);
                    item.Name = "lstItem" + index.ToString();
                    item.Size = new System.Drawing.Size(736, 132);
                    item.lblDescription.Text = product.description;
                    flpListingPanel.Controls.Add(item);
                }
            }
            else if (category.Equals("Vehicle"))
            {
                foreach (ProductListingModel product in productsToDisplay)
                {
                    NadlanProduct item = new NadlanProduct();
                    // item.Location = new System.Drawing.Point(3, 3);
                    item.Name = "lstItem" + index.ToString();
                    item.Size = new System.Drawing.Size(736, 132);
                    item.lblDescription.Text = product.description;
                    flpListingPanel.Controls.Add(item);
                }
            }*/
        }
        private void ListingView_Load(object sender, EventArgs e)
        {

        }
    }
}
