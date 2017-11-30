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
            double dFina = double.Parse(fina.Text);
            double dNayuta = 50.0;

            if(dfina > 3)
            {
                dFina /= 100;
            }

            double dBMI = dfina / dnayuta / dnayuta;

            DisplayAlert("BMI", dBMI+":太い", "OK");
        }
    }


}
