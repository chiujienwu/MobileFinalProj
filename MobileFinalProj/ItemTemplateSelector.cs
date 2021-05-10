using MobileFinalProj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileFinalProj
{
    public class ItemTemplateSelector: DataTemplateSelector
    {
        public DataTemplate RegularItemTemplate { get; set; }
        public DataTemplate HigvalueItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var itemTemp = (Item)item;
            var itemTempPrice = itemTemp.Price;

            if(itemTempPrice >= 1000.00)
            {
                return HigvalueItemTemplate;
            }

            return RegularItemTemplate;
        }
    }
}
