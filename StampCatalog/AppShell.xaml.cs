using StampCatalog.Models;
using StampCatalog.Services;
using StampCatalog.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StampCatalog
{
    public partial class AppShell : Shell
    {
        public AppShell(StampService stamps)
        {
            InitializeComponent();

            List<FlyoutInfo> flyoutInfo = new List<FlyoutInfo>();
            flyoutInfo.Add(new FlyoutInfo(Category.SK, "slovak.png", "SLOVENSKÁ REPUBLIKA"));
            
            foreach (FlyoutInfo info in flyoutInfo)
            {
                List<string> names = stamps.GetTabsNames(info.Category);

                FlyoutItem flyout = new FlyoutItem();
                flyout.Title = info.Title;

                Tab tab = new Tab();
                
                foreach (string name in names)
                {
                    ShellContent content = new ShellContent();
                    content.Title = name;
                    content.ContentTemplate = new DataTemplate(typeof(StampsView));
                    tab.Items.Add(content);
                }

                flyout.Items.Add(tab);
                Items.Add(flyout);
            }
        }

        public class FlyoutInfo
        {
            public Category Category { get; set; }
            public string Image { get; set; }
            public string Title { get; set; }

            public FlyoutInfo(Category category, string image, string title)
            {
                Category = category;
                Image = image;
                Title = title;
            }
        }
    }
}