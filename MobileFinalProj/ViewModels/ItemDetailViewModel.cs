using MobileFinalProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinalProj.Model
{
    public class ItemDetailViewModel : BaseViewModel
    {
        //public Item Item { get; set; }

        private Item _selectedItem;

        public Item SelectedItem
        {
            get { return _selectedItem;  }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ItemDetailViewModel()
        {
            SelectedItem = new Item();
        }

    }
}
