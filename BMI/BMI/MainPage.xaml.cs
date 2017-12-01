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


            DisplayAlert("BMI",dBMI+ "デブ", "OK");
            if(dBMI < 18.5)
            {
                DisplayAlert("BMI", dBMI + ":低体重(痩せ型)", "OK");
            }else if(dBMI < 25.0)
            {
                DisplayAlert("BMI", dBMI + ":普通体重", "OK");
            }
        }
    }
}
