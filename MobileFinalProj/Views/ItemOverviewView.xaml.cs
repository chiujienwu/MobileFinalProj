using MobileFinalProj.Model;
using MobileFinalProj.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileFinalProj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemOverviewView : ContentPage
    {
        public ItemOverviewView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.ItemOverviewViewModel;
        }

        private void AddItemButton_OnClicked(object sender, EventArgs e)
        {
            var newItem = new Item
            {
                Id = Guid.Parse("{27629374-72AA-40CC-9819-993440356585}"),
                ItemName = "Mike Schmidt",
                ImageName = "mikeschmidt.png",
                ImageUrl = "https://i.etsystatic.com/16316958/r/il/3e8b08/2049019404/il_794xN.2049019404_jbvj.jpg",
                Price = 11.00,
                Quantity = 1
            };

            //Items.Add(newItem);
        }

        private async void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await this.Navigation.PushAsync(new ItemDetailView());
        }  
    }
}