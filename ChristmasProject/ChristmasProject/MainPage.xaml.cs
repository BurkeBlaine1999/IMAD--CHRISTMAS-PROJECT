using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChristmasProject
{
    public partial class MainPage : Xamarin.Forms.ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Please Enter Employee user names at bottom for login!!

        private void btnChangeLabel_Clicked(object sender, EventArgs e)
        {
            if (entryUsername.Text == User || entryUsername.Text == User2|| entryUsername.Text == User3|| entryUsername.Text == User4)
            {
                Identification = true;

                if (Identification == true)
                {
                    lblMessage.Text = "Welcome back " + entryUsername.Text;

                    Navigation.PushAsync(new TabbedPage1());

                }
            }
            else
            {
                Identification = false;
                lblMessage.Text = "Incorrect user name or password. You entered " + entryUsername.Text;
                entryUsername.Text = "";
                btnChangeLabel.Text = "Login";
            }
                            

        }

        public void NewAccount_Clicked(object sender, EventArgs e)
        { 
            Navigation.PushAsync(new signUpPage());
        }

        Boolean Identification;
        //Please Enter Employee user names below for login!!
        String User = "Blaine";
        String User2 = "Guest";
        String User3 = "Manager";
        String User4 = "Admin";
    }
}
