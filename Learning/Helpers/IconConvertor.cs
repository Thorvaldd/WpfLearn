using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Learning.Model;

namespace Learning.Helpers
{
    public class IconConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var model = value as Customer;
            var tmp = DateTime.Now;
            var span = model.WorkedHours.Subtract(tmp);
            var hours = span.TotalHours;

            return hours > 100 ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
