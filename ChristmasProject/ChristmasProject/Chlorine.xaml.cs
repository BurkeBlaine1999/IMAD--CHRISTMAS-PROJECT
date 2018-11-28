using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristmasProject
{
    public partial class Chlorine : Xamarin.Forms.ContentPage
    {
        public double level = 0;

        public Chlorine()
        {
            InitializeComponent();
        }


         public void ChlorineEntered_Clicked(object sender, EventArgs e)
        {
            double level = double.Parse(ClLevel.Text);

            if (level <= 0.25 && level > 0)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Chlorine levels are extremely Low! Switch off chlorine and acid pumps and manually feed! ";
            }
            if (level <= 0.5 && level > 0)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Chlorine levels are very Low! Chlorine and Calibration are needed! ";
            }
            if (level <= 1.2 && level > 0)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Chlorine levels are Low! Add Chlorine! ";
            }
            else if (level >= 1.2 && level <= 1.5)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Chlorine Levels are stable!";
            }
            else if (level > 1.5 && level <= 5)
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Ph is high! Do not add more Chlorine! ";
            }
            else if (level > 5 )
            {
                lblMessage.Text = "";
                lblMessage.Text = "The Ph is Dangerously high! Do not add more Chlorine! ";
            }
            else
            {
                lblMessage.Text = "";
                lblMessage.Text = "Error , Please try again";
            }

        }

    }

}