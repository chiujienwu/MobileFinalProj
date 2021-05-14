using MobileFinalProj.Model;
using MobileFinalProj.Utility;
using MobileFinalProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileFinalProj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailView : ContentPage
    {
        public ItemDetailView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.ItemDetailViewModel;
        }

        private async void SaveItemButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Item saved", "Done");
        }
    }
}