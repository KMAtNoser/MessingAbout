using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinFormsFromWizard.Services
{
    public class IsKevinConvertor :
        IValueConverter
    {
        public object Convert(
            object value, 
            Type targetType,
            object parameter, 
            CultureInfo culture) => (value != null) && (value.ToString().ToLower() == "kevin");

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
