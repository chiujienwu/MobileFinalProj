using MobileFinalProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinalProj.Utility
{
    public static class ViewModelLocator
    {
        public static ItemOverviewViewModel ItemOverviewViewModel { get; set; }
            = new ItemOverviewViewModel();

        public static ItemDetailViewModel ItemDetailViewModel { get; set; }
            = new ItemDetailViewModel();
    }
}
