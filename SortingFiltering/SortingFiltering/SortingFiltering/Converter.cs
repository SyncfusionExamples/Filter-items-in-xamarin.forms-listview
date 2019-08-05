using SortingFiltering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SortingFiltering
{
    [Preserve(AllMembers = true)]
    public class ListViewBoolToSortImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var sortOptions = (ListViewSortOptions)value;

            if (sortOptions == ListViewSortOptions.Ascending)
                return ImageSource.FromResource("SortingFiltering.Images.Sort_Ascending.png", assembly);
            else if (sortOptions == ListViewSortOptions.Descending)
                return ImageSource.FromResource("SortingFiltering.Images.Sort_Decending.png", assembly);
            else
                return ImageSource.FromResource("SortingFiltering.Images.SortIcon.png", assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
