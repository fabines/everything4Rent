using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.Product
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Submitted Successfuly");
        }

        private void ItemView_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Router.navigate("PRODUCT_VIEW", "RENT_LISTING");
            this.clearAll();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You Request Submmitted");
            Router.navigate("PRODUCT_VIEW", "RENT_LISTING");
            this.clearAll();
        }

        private void clearAll()
        {
            this.petsProducts1.Visible = false;
            this.nadlanProduct1.Visible = false;
            this.vehicleProducts1.Visible = false;
            this.secondHandProducts1.Visible = false;
        }
    }
}
