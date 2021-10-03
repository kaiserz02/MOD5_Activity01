using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MOD5_Activity01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void AccelerometedPage_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccelerometerPage());
        }
        private async void BarometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarometerPage());
        }
        private async void MagnetometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagnetometerPage());
        }
        private async void ConnectivityPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }
    }
}
