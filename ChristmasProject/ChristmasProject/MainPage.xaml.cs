using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChristmasProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnChangeLabel_Clicked(object sender, EventArgs e)
        {
            if(entryUsername.Text == User)
            {
                Identification = true;

                if(Identification == true)
                {
                    lblMessage.Text = "Welcome back " + entryUsername.Text ;
                    
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

        Boolean Identification;
        String User = "Blaine";
    }
}
