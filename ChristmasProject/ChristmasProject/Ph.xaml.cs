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
    public partial class Ph : Xamarin.Forms.ContentPage
    {
        public double Phlvl = 0;

        public Ph()
        {
            InitializeComponent();
        }

        public void Ph_clicked(object sender, EventArgs e)
        {
            double Phlvl = double.Parse(PhLevels.Text);

            if (Phlvl < 7.0 && Phlvl > 0)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Ph is Low! Add acid! ";
            }
            else if (Phlvl <= 8.0 && Phlvl >= 7.0)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Ph is stable!";
            }
            else if (Phlvl > 7.0 && Phlvl < 14)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Ph is high! Do not add more Chlorine or acid! ";
            }
            else
            {
                lblMessage.Text = "";
                lblMessage.Text = "Error";
            }

        }
    }
}