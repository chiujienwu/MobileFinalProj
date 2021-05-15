using MobileFinalProj.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

using System.Windows.Input;
using Xamarin.Forms;

namespace MobileFinalProj.ViewModels
{
    public class ItemOverviewViewModel: BaseViewModel
    {
        private ObservableCollection<Item> _items;
        public ICommand LoadCommand { get; }
        public ICommand AddCommand { get; }

        //constructor
        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        //during binding, if an Observable Collection is null, it won't bind
        public ItemOverviewViewModel()
        {
            //Items = new ObservableCollection<Item>();
            Items = new ObservableCollection<Item>(ItemRepository.Items);

            //LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
        }

        public void OnLoadCommand()
        {

        }

        public void OnAddCommand()
        {
            
        }

    }
}
