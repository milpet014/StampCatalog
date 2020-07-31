using StampCatalog.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StampCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StampDetailView : ContentPage
    {
        public StampDetailView(Stamp stamp)
        {
            InitializeComponent();
            BindingContext = stamp;
        }
    }
}