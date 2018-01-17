using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Everything4Rent.Modules.AddProducts
{
    public partial class addProductView : UserControl
    {
        addProduct productModel = new addProduct();
        private string[] categoreis = { " ", "Nadlan", "Vehicle", "SecondHand", "Pets" };
        private string[] descriptionNadlan = { " ", "apartment", "room", "office", "parlor", "B&B", "shop" };
        private string[] descriptionPets = { " ", "dog", "cat", "rodens", "bird", "reptiles" };
        private string[] descriptionVehicle = { " ", "car", "jeep", "tracks", "motorcycle", "sailing" };
        private string[] descriptionSecondHand = { " ", "house Tools", "collectables", "Musical Instuments", "cloths", "books", "electrical" };
        private int runningPID = 1000;
        public addProductView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            productModel.category = this.categoreis[ddlCategory.SelectedIndex];
            lblCity.Visible = false;
            lblStreet.Visible = false;
            lblMaxCapacity.Visible = false;
            ddlCity.Visible = false;
            ddlStreet.Visible = false;
            ddlMaxCapacity.Visible = false;
            lblEngine.Visible = false;
            lblColor.Visible = false;
            lblProdYear.Visible = false;
            ddlEngine.Visible = false;
            ddlColor.Visible = false;
            ddlProdYear.Visible = false;
            lblSubCategory.Visible = false;
            ddlSubCategory.Visible = false;
            lblBreed.Visible = false;
            ddlBreed.Visible = false;
            lblAge.Visible = false;
            ddlAge.Visible = false;
            lblSex.Visible = false;
            ddlSex.Visible = false;
            if (productModel.category.Equals("Nadlan"))
            {
                lblCity.Visible = true;
                lblStreet.Visible = true;
                lblMaxCapacity.Visible = true;
                ddlCity.Visible = true;
                ddlStreet.Visible = true;
                ddlMaxCapacity.Visible = true;
                ddlDescription.Items.Clear();
                for (int i = 0; i < descriptionNadlan.Length; i++)
                {
                    ddlDescription.Items.Add(descriptionNadlan[i]);
                }

            }
            else if (productModel.category.Equals("Vehicle"))
            {
                lblEngine.Visible = true;
                lblColor.Visible = true;
                lblProdYear.Visible = true;
                ddlEngine.Visible = true;
                ddlColor.Visible = true;
                ddlProdYear.Visible = true;
                ddlDescription.Items.Clear();
                for (int i = 0; i < descriptionVehicle.Length; i++)
                {
                    ddlDescription.Items.Add(descriptionVehicle[i]);
                }
            }
            else if (productModel.category.Equals("SecondHand"))
            {
                lblSubCategory.Visible = true;
                ddlSubCategory.Visible = true;
                ddlDescription.Items.Clear();
                for (int i = 0; i < descriptionSecondHand.Length; i++)
                {
                    ddlDescription.Items.Add(descriptionSecondHand[i]);
                }
            }
            else if (productModel.category.Equals("Pets"))
            {
                lblBreed.Visible = true;
                ddlBreed.Visible = true;
                lblAge.Visible = true;
                ddlAge.Visible = true;
                lblSex.Visible = true;
                ddlSex.Visible = true;
                ddlDescription.Items.Clear();
                for (int i = 0; i < descriptionPets.Length; i++)
                {
                    ddlDescription.Items.Add(descriptionPets[i]);
                }
            }
        }

        private void ddlComposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: add button of add product and defined bundleID
            productModel.composition = (string)ddlComposition.SelectedItem;
            if (productModel.composition == "Bundle")
            {
                btnAddProduct.Visible = true;
                ddlBundle.Visible = true;
                lblBundle.Visible = true;
            }
            if (productModel.composition == "Single Item")
            {
                btnAddProduct.Visible = false;
                ddlBundle.Visible = false;
                lblBundle.Visible = false;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool ifAssigning = assigning();
                if (!ifAssigning)
                    MessageBox.Show("Please enter all fields");
                else
                {
                    productModel.addToDatabase();
                    clear(true);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void lblEngine_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                bool ifAssigning = assigning();
                if (!ifAssigning)
                    MessageBox.Show("Please enter all fields");
                else
                {
                    productModel.addToDatabase();
                    clear(false);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }



        }

        private void ddlCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear(true);
        }

        private void clear(bool clearBundle)
        {
            ddlCategory.SelectedIndex = 0;
            ddlPurpose.SelectedIndex = 0;

            ddlCondition.SelectedIndex = 0;
            ddlDescription.Items.Clear();
            ddlPrice.Text = "";
            ddlDeposite.Text = "";
            ddlAddons.Text = "";
            if (clearBundle)
            {
                ddlBundle.Text = "";
                ddlComposition.Visible = true;
                label3.Visible = true; // LblComposition
                ddlComposition.SelectedIndex = 0;
            }
            else
            {
                ddlBundle.Visible = false;
                lblBundle.Visible = false;
                ddlComposition.Visible = false;
                label3.Visible = false; // LblComposition  
            }
            ddlPurpose.ResetText();
            lblCity.Visible = false;
            lblStreet.Visible = false;
            lblMaxCapacity.Visible = false;
            ddlCity.Visible = false;
            ddlStreet.Visible = false;
            ddlMaxCapacity.Visible = false;
            lblEngine.Visible = false;
            lblColor.Visible = false;
            lblProdYear.Visible = false;
            ddlEngine.Visible = false;
            ddlColor.Visible = false;
            ddlProdYear.Visible = false;
            lblSubCategory.Visible = false;
            ddlSubCategory.Visible = false;
            lblBreed.Visible = false;
            ddlBreed.Visible = false;
            lblAge.Visible = false;
            ddlAge.Visible = false;
            lblSex.Visible = false;
            ddlSex.Visible = false;
            ddlDeposite.Visible = false;
            lblDeposite.Visible = false;
            lblPrice.Visible = true;
            ddlPrice.Visible = true;

        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            productModel.purpose = (string)ddlPurpose.SelectedItem;
            if (productModel.purpose == "Loan")
            {
                ddlPrice.Visible = false;
                lblPrice.Visible = false;
                ddlDeposite.Visible = true;
                lblDeposite.Visible = true;
            }
            else
            {
                ddlPrice.Visible = true;
                lblPrice.Visible = true;
                ddlDeposite.Visible = false;
                lblDeposite.Visible = false;
            }
        }

        //check if all of fields are filled.
        public bool assigning()
        {
            if (ddlCategory.SelectedItem == null || ddlCategory.SelectedIndex == 0)
                return false;
            else productModel.category = this.categoreis[ddlCategory.SelectedIndex];
            if (ddlPurpose.SelectedItem == null || ddlPurpose.SelectedIndex == 0)
                return false;
            else productModel.purpose = (string)ddlPurpose.SelectedItem;
            if (ddlComposition.SelectedItem == null || ddlComposition.SelectedIndex == 0)
                return false;
            else productModel.composition = (string)ddlComposition.SelectedItem;
            if (ddlCondition.SelectedItem == null || ddlCondition.SelectedIndex == 0)
                return false;
            else productModel.condition = (string)ddlCondition.SelectedItem;
            productModel.from = dateFrom.Value.ToShortDateString();
            productModel.to = dateTo.Value.ToShortDateString();
            if (ddlAddons.Text == "")
                return false;
            else productModel.addons = ddlAddons.Text;
            if (ddlDeposite.Text == "")
                productModel.deposite = "0";
            else productModel.deposite = ddlDeposite.Text;
            if (ddlDeposite.Text == "" && ddlPrice.Text == "")
            {
                if (productModel.purpose.Equals("Loan"))
                    productModel.price = "0";
                else return false;
            }
            else if (ddlPrice.Text == "")
                productModel.price = "0";
            else productModel.price = ddlPrice.Text;
            if (ddlDescription.SelectedItem == null)
                return false;
            else productModel.description = (string)ddlDescription.SelectedItem;
            if (ddlBundle.Text == "" && ddlBundle.Visible)
                return false;
            else productModel.BundleID = ddlBundle.Text;
            if (productModel.category.Equals("Nadlan"))
            {
                if (ddlCity.Text == "")
                    return false;
                else productModel.city = ddlCity.Text;
                if (ddlStreet.Text == "")
                    return false;
                else productModel.street = ddlStreet.Text;
                if (ddlMaxCapacity.Text == "")
                    return false;
                else productModel.maxCapacity = ddlMaxCapacity.Text;
            }
            else if (productModel.category.Equals("Vehicle"))
            {
                if (ddlProdYear.Text == "")
                    return false;
                else productModel.prodYear = ddlProdYear.Text;
                if (ddlEngine.Text == "")
                    return false;
                else productModel.engine = ddlEngine.Text;
                if (ddlColor.Text == "")
                    return false;
                else productModel.color = ddlColor.Text;
            }
            else if (productModel.category.Equals("SecondHand"))
            {
                if (ddlSubCategory.Text == "")
                    return false;
                else productModel.SubCategory = ddlSubCategory.Text;

            }
            else if (productModel.category.Equals("Pets"))
            {
                if (ddlSex.Text == "")
                    return false;
                else productModel.sex = ddlSex.Text;
                if (ddlAge.Text == "")
                    return false;
                else productModel.age = ddlAge.Text;
                if (ddlBreed.Text == "")
                    return false;
                else productModel.breed = ddlBreed.Text;
            }
            return true;
        }

        private void ddlDeposite_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProductView_Load(object sender, EventArgs e)
        {

        }

        private void ddlBundle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
