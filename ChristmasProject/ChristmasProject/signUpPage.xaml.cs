using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Text;
namespace ChristmasProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class signUpPage : ContentPage
    {
        public signUpPage()
        {
            InitializeComponent();
        }

        string path = @"c:\temp\MyTest.txt";

     /*   public void Main(string[] args)
        {
            string FileName = @"C:\Users\Owner\Desktop";
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "This is some text");
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");
                AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

                for (int i = 1; i < 120; i++)
                {
                    AddText(fs, Convert.ToChar(i).ToString());

                }
            }
        } */

        static void WriteFile(string FileName)
        {

        }


        static void ReadFile(string FileName)
        {

        }


        public String signUpUsername = "";


        public void signUp_Clicked(object sender, EventArgs e)
        {
            String[] newUserArray;
            newUserArray = new String[10];

            String[] newPassArray;
            newPassArray = new String[10];


            if (newUserName.Text != null || newPassword.Text != null)
            {
                //Checks for a vacancy in the new username and password arrays and sets value
                for (int i = 0; i < 10; i++)
                {
                    if (newUserArray[i] != "" && newPassArray[i] != "")
                    {
                        newUserArray[i] = newUserName.Text;
                        int newArrayNum = i;
                        Application.Current.Properties["newUserArray[i]"] = newUserArray[i];
                        Application.Current.Properties["newPassArray[i]"] = newPassArray[i];
                        Navigation.PushAsync(new MainPage());
                    }
                }

            }

            //Error message
            if (newUserName.Text == null || newPassword.Text == null)
            {
                errorMsg.Text = "Error --> Username / Password box was not filled , please try again!";
            }

        }
    }
}