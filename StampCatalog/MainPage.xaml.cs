using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace StampCatalog
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Routing.RegisterRoute("sk1993", typeof(MainPage));
        }
    }
}