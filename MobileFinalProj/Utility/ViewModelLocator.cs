using MobileFinalProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinalProj.Utility
{
    public static class ViewModelLocator
    {
        //used to locate the correct view model and return it
        //can be used with dependency injection container that can on the fly create a new view model
        //in this example we will only create static ones as properties of the object and instantiate.
        public static ItemOverviewViewModel ItemOverviewViewModel { get; set; }
            = new ItemOverviewViewModel();

        public static ItemDetailViewModel ItemDetailViewModel { get; set; }
            = new ItemDetailViewModel();
    }
}
