using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Everything4Rent.Common
{
    class Router
    {
        public static main root;
        public static void navigate(string currentPage, string nextPage)
        {
            switch (currentPage + "->" + nextPage)
            {
                case "LOGIN->DASHBOARD":
                    clear(root.loginView1);
                    show(root.userDashBoard);
                    break;
                case "HEADER->USER":
                    clearALL();
                    show(root.userDashBoard);
                    break;
                case "HEADER->LOGIN":
                    clearALL();
                    show(root.loginView1);
                    break;
                case "HEADER->HOMEPAGE":
                    clearALL();
                    show(root.homePage1);
                    break;
                case "HOMEPAGE->SEARCH":
                    clear(root.homePage1);
                    show(root.searchView);
                    break;
                case "SEARCH->LISTVIEW":
                    clear(root.searchView);
                    show(root.listingView);
                    break;
                case "SIGNUP->LOGIN":
                    clear(root.signUpView1);
                    show(root.loginView1);
                    break;
                case "LOGIN->SIGNUP":
                    clear(root.loginView1);
                    show(root.signUpView1);
                    break;
                case "DASHBOARD->ADDPRODUCT":
                    clear(root.userDashBoard);
                    show(root.addProductView1);
                    break;
                case "SEARCH->RENT_LISTING":
                    clear(root.searchView);
                    show(root.listingView);
                    break;
                case "RENT_LISTING->PRODUCT_VIEW":
                    clear(root.listingView);
                    show(root.productItem);
                    break;
                case "PRODUCT_VIEW->RENT_LISTING":
                    show(root.listingView);
                    clear(root.productItem);
                    break;
                case "DASHBOARD->SHOWADS":
                    clear(root.userDashBoard);
                    show(root.adsPage);
                    break;
                default:
                    break;
                    
            }
        }

        private static void clear(UserControl userControl)
        {
            userControl.Visible = false;
        }

        private static void show(UserControl userControl)
        {
            userControl.Visible = true;
        }

        private static void clearALL()
        {
            root.loginView1.Visible = false;
            root.userDashBoard.Visible = false;
            root.homePage1.Visible = false;
            root.searchView.Visible = false;
            root.listingView.Visible = false;
            root.adsPage.Visible = false;
            root.signUpView1.Visible = false;
            root.addProductView1.Visible = false;
            root.productItem.Visible = false;
        }
    }
}
