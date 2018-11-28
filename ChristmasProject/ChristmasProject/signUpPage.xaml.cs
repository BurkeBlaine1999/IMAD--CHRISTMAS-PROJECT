using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristmasProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class signUpPage : ContentPage
    {
        public signUpPage()
        {
            InitializeComponent();
        }

        public String signUpUsername = "";


        private void signUp_Clicked(object sender, EventArgs e)
        {


            if (newUserName != null || newPassword != null)
            {
                Navigation.PushAsync(new TabbedPage1());

            }

            if (newUserName == null || newPassword == null)
            {
                errorMsg.Text = "Error --> Username / Password box was not filled , please try again!";
            }

        }
    }
}