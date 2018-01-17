using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent.Modules.Search
{
    public partial class SearchView : UserControl
    {
        private SearchModel searchModel;
        private string[] categoreis = { "Nadlan", "Vehicle", "SecondHand", "Pets" };
        public SearchView()
        {
            InitializeComponent();
            this.searchModel = new SearchModel();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchModel.category = this.categoreis[ddlCategory.SelectedIndex];
            searchModel.composition = (string) ddlComposition.SelectedItem;
            searchModel.purpose = (string) ddlType.SelectedItem;
            searchModel.condition = (string) ddlCondition.SelectedItem;
            searchModel.from = dateFrom.Value.ToShortDateString();
            searchModel.to = dateTo.Value.ToShortDateString();
            searchModel.doSearch();
            // Router.navigate("SEARCH", "LISTVIEW");
        }

        private void SearchView_Load(object sender, EventArgs e)
        {

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
