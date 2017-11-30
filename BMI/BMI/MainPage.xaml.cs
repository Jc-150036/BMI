using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double dHeight = double.Parse(height.Text);
            double dWeight = 50.0;
            if(dHeight > 3)
            {
                dHeight /= 100;
            }

            double dBMI = dWeight / dHeight / dHeight;


            DisplayAlert("BMI", "デブ", "OK");
        }
    }
}
