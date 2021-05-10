using MobileFinalProj.Model;
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
        //public ObservableCollection<Item> Items { get; set; }
        public ItemOverviewView()
        {
            InitializeComponent();

            /*            Items = new ObservableCollection<Item>
                        {
                            new Item
                            {
                                Id = 1,
                                ItemName = "Nolan Ryan",
                                ImageName = "nolanryan.png",
                                ImageUrl = "https://i.ebayimg.com/images/g/j1YAAOSwuSZe8v9G/s-l1600.jpg",
                                Price = 2.45,
                                Quantity = 1

                            },
                            new Item
                            {
                                Id = 2,
                                ItemName = "Rickey Henderson",
                                ImageName = "rickeyhenderson.png",
                                ImageUrl = "https://retrosportcards.files.wordpress.com/2019/05/unknown-1.jpeg?w=764",
                                Price = 2000.00,
                                Quantity = 1

                            },
                            new Item
                            {
                                Id = 3,
                                ItemName = "Eddie Murray",
                                ImageName = "eddiemurray.png",
                                ImageUrl = "https://www.oldsportscards.com/wp-content/uploads/2019/12/1978-Topps-36-Eddie-Murray-Rookie-Card.jpeg",
                                Price = 550.00,
                                Quantity = 1

                            },
                        };

                        ItemsListView.ItemsSource = Items;
                    }

                    private void AddItemButton_OnClicked(object sender, EventArgs e)
                    {
                        var newItem = new Item
                        {
                            Id = 4,
                            ItemName = "Mike Schmidt",
                            ImageName = "mikeschmidt.png",
                            ImageUrl = "https://i.etsystatic.com/16316958/r/il/3e8b08/2049019404/il_794xN.2049019404_jbvj.jpg",
                            Price = 11.00,
                            Quantity = 1
                        };

                        Items.Add(newItem);
                    }

                    private async void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
                    {
                        await this.Navigation.PushAsync(new ItemDetailView(e.Item as Item));
                    }*/

        }
    }
}