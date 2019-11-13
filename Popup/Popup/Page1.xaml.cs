using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Popup
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(15), () =>
            {
                DisplayAlert("Page1", "Time : " + DateTime.Now.ToString("T"), "Exit");
                return true;
            });
        }
    }

}
  