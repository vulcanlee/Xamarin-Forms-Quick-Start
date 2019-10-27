using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BindConverter.Converters
{
    public class NumberToAlphabetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = "";
            if (value is int)
            {
                var fooObject = (int)value;
                if (fooObject == 1)
                {
                    result = "a";
                }
                else if (fooObject == 2)
                {
                    result = "b";
                }
                else if (fooObject == 3)
                {
                    result = "c";
                }
            }
            Debug.WriteLine($"Convert {result}");
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = 0;
            if (value != null && value is string)
            {
                var fooObject = value as string;
                if (fooObject == "a")
                {
                    result = 1;
                }
                else if (fooObject == "b")
                {
                    result = 2;
                }
                else if (fooObject == "c")
                {
                    result = 3;
                }
            }
            Debug.WriteLine($"ConvertBack {result}");
            return result;
        }
    }
}
