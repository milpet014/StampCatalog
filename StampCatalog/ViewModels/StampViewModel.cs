using StampCatalog.Models;
using StampCatalog.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace StampCatalog.ViewModels
{
    public class StampViewModel
    {
        public List<Stamp> Stamps { get; set; }
        public ICommand TapCommand { get; }

        public StampViewModel(List<Stamp> stamps)
        {
            Stamps = stamps;
            TapCommand = new Command<Stamp>(OnTap);
        }

        public void OnTap(Stamp stamp)
        {
            Shell.Current.Navigation.PushAsync(new StampDetailView(stamp));
        }
    }
}