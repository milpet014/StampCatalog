﻿using StampCatalog.Models;
using StampCatalog.ViewModels;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StampCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StampsView : ContentPage
    {
        public StampsView(List<Stamp> stamps)
        {
            InitializeComponent();
            BindingContext = new StampViewModel(stamps);
        }
    }
}