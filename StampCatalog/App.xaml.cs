﻿using StampCatalog.Services;
using Xamarin.Forms;

namespace StampCatalog
{
    public partial class App : Application
    {
        public StampService Stamps { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage();
        }

        protected override async void OnStart()
        {
            Stamps = new StampService();
            await Stamps.Initialize();

            MainPage = new AppShell(Stamps);
        }
    }
}
