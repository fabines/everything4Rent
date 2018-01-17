using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Modules.Product;
using Everything4Rent.Modules.RentListings;

namespace Everything4Rent.Modules.RentItem
{
    public partial class NadlanProduct : UserControl
    {
        
        public NadlanProduct()
        {
           // ProductModel product = new ProductModel();
          //  this.displayObject = product.getNadlanProduct();
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
    }
}
