using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileFinalProj.Model
{
    public class Item : INotifyPropertyChanged
    {
        private int _id;
        private string _itemName;
        private string _imageName;
        private string _imageUrl;
        private double _price;
        private int _quantity;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            } 
        }
        public string ItemName
        {
            get => _itemName;
            set
            {
                _itemName = value;
                RaisePropertyChanged(nameof(ItemName));
            }
        }
        public string ImageName
        {
            get => _imageName;
            set
            {
                _imageName = value;
                RaisePropertyChanged(nameof(ImageName));
            }
        }
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                RaisePropertyChanged(nameof(Quantity));
            }
        }

        //represents the method that will handle when the property has changes
        //on a component
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
