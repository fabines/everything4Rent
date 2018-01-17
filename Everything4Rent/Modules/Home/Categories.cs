using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.Home
{
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btnRealEstate_Click(object sender, EventArgs e)
        {
            Router.root.searchView.ddlCategory.SelectedIndex = Router.root.searchView.ddlCategory.FindString("Real Estate");
            Router.navigate("HOMEPAGE", "SEARCH");
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Router.root.searchView.ddlCategory.SelectedIndex = Router.root.searchView.ddlCategory.FindString("Vehicles");
            Router.navigate("HOMEPAGE", "SEARCH");
        }

        private void btnSecHand_Click(object sender, EventArgs e)
        {
            Router.root.searchView.ddlCategory.SelectedIndex = Router.root.searchView.ddlCategory.FindString("2nd Hand");
            Router.navigate("HOMEPAGE", "SEARCH");
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            Router.root.searchView.ddlCategory.SelectedIndex = Router.root.searchView.ddlCategory.FindString("Pets");
            Router.navigate("HOMEPAGE", "SEARCH");
        }
    }
}
