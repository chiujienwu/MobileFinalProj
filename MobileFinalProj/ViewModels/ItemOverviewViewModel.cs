using MobileFinalProj.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MobileFinalProj.ViewModels
{
    public class ItemOverviewViewModel: BaseViewModel
    {
        private ObservableCollection<Item> _items;

        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public ItemOverviewViewModel()
        {
            //Items = new ObservableCollection<Item>();
            Items = new ObservableCollection<Item>(ItemRepository.Items);
        }
    }
}
