using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BindConverter.Converters
{
    public class StringToBooleanInvertConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result = true;
            if (value == null)
            {
                result = false;
            }
            else if (value is string)
            {
                string fooString = value as string;
                if (string.IsNullOrEmpty(fooString))
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            return !result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
