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

        public void btnChangeLabel_Clicked(object sender, EventArgs e)
        {
            String[] userArray;
            userArray = new String[10];

            String[] passArray;
            passArray = new String[10];

         //   newUserArray[i].text

            userArray[0] = "Blaine";
            userArray[1] = "Andrew";
            userArray[2] = "Colin";
            userArray[3] = "Aaron";
            userArray[4] = "Thomas";
            userArray[5] = "Conor";
            userArray[6] = "Ciaran";
            userArray[7] = "Damian";

            passArray[0] = "Blaine";
            passArray[1] = "Andrew";
            passArray[2] = "Colin";
            passArray[3] = "Aaron";
            passArray[4] = "Thomas";
            passArray[5] = "Conor";
            passArray[6] = "Ciaran";
            passArray[7] = "Damian";

            

            if (entryUsername.Text == userArray[0] || entryUsername.Text == userArray[1] || entryUsername.Text == userArray[2] || entryUsername.Text == userArray[3]
                || entryUsername.Text == userArray[4] || entryUsername.Text == userArray[5] || entryUsername.Text == userArray[6] || entryUsername.Text == userArray[7])
            {
                if (entryPassword.Text == passArray[0] || entryPassword.Text == passArray[1] || entryPassword.Text == passArray[2] || entryPassword.Text == passArray[3]
                || entryPassword.Text == passArray[4] || entryPassword.Text == passArray[5] || entryPassword.Text == passArray[6] || entryPassword.Text == passArray[7])
                {
                    Identification = true;
                }

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
