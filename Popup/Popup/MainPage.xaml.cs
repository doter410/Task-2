using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;


namespace Popup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(30), () =>
            { 
                DisplayAlert("Page1", "Time : " + DateTime.Now.ToString("T"), "Exit");
                return true;
            });
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

    }
}   