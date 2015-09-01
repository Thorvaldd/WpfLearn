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
            if (value is DateTime)
            {
                var timveValue = (DateTime) value;
                var tmp = DateTime.Now;
                var span = timveValue.Subtract(tmp);
                var hours = span.TotalHours;

                return hours > 100 ? Visibility.Visible : Visibility.Hidden;
            }
            if(value is string)
            {
                return "String Value passed to IConvertor";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
