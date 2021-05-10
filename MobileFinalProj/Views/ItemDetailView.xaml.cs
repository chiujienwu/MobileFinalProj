using MobileFinalProj.Model;
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
        //public Item Item { get; set; }
        //public ItemDetailViewModel ItemDetailViewModel { get; set; }
        //public List<Item> Items { get; set; }

        public ItemDetailView(Item item)
        {
            InitializeComponent();
            //Item = item;

            //    ItemDetailViewModel = new ItemDetailViewModel()
            //    {
            //        Item = new Item
            //        {
            //            Id = 1,
            //            ItemName = "Nolan Ryan",
            //            ImageName = "nolanryan.png",
            //            ImageUrl = "https://i.ebayimg.com/images/g/j1YAAOSwuSZe8v9G/s-l1600.jpg",
            //            Price = 2.45,
            //            Quantity = 1
            //        }
            //};

            //    this.BindingContext = this;

            //Items = new List<Item>
            //{
            //    new Item
            //    {
            //        Id = 1,
            //        ItemName = "Nolan Ryan",
            //        ImageName = "nolanryan.png",
            //        ImageUrl = "https://i.ebayimg.com/images/g/j1YAAOSwuSZe8v9G/s-l1600.jpg",
            //        Price = 2.45,
            //        Quantity = 1

            //    },
            //    new Item
            //    {
            //        Id = 2,
            //        ItemName = "Rickey Henderson",
            //        ImageName = "rickeyhenderson.png",
            //        ImageUrl = "https://retrosportcards.files.wordpress.com/2019/05/unknown-1.jpeg?w=764",
            //        Price = 2000.00,
            //        Quantity = 1

            //    },
            //    new Item
            //    {
            //        Id = 3,
            //        ItemName = "Eddie Murray",
            //        ImageName = "eddiemurray.png",
            //        ImageUrl = "https://www.oldsportscards.com/wp-content/uploads/2019/12/1978-Topps-36-Eddie-Murray-Rookie-Card.jpeg",
            //        Price = 550.00,
            //        Quantity = 1

            //    },

            //};

            //this.BindingContext = Item;
        }

    //private async void SaveItemButton_OnClicked(object sender, EventArgs e)
    //    {
    //        await DisplayAlert("Success", "Item saved", "Done");
    //    }
    //}
}