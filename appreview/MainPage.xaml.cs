using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.StoreReview;

namespace appreview
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await CrossStoreReview.Current.RequestReview(true);
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await CrossStoreReview.Current.RequestReview(false);
        }
    }
}
