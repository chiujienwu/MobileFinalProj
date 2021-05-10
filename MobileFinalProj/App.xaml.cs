using MobileFinalProj.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileFinalProj
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ItemDetailView();
            MainPage = new NavigationPage (new ItemOverviewView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
