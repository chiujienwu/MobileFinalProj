using MobileFinalProj.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileFinalProj
{
    public partial class MainPage : ContentPage
    {
        Item item = new Item
        {
            Id = Guid.Parse("{11DB10F5-C461-490F-A7A3-5BA5AF3A58AF}"),
            ItemName = "Ricky Henderson",
            Price = 2200.00,
            Quantity = 1
        };
        public MainPage()
        {
            InitializeComponent();



            MainGrid.BindingContext = item;

            /*Binding itemNameBinding = new Binding();
            itemNameBinding.Source = item;
            itemNameBinding.Path = "ItemName";
            NameEntry.SetBinding(Entry.TextProperty, itemNameBinding);

            Binding priceBinding = new Binding();
            priceBinding.Source = item;
            priceBinding.Path = "Price";
            PriceEntry.SetBinding(Entry.TextProperty, priceBinding);*/


        }

        public void Item_Button_Clicked(object sender, EventArgs e)
        {
            item.Price++;
        }

    }
}
