using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MVVMPattern.Converters
{
    public class AgeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = Color.Transparent;
            if (value != null && value is int)
            {
                int age = (int)value;
                if (age <= 20)
                    color = Color.Red;
                else if (age <= 40)
                    color = Color.Green;
                else if (age <= 60)
                    color = Color.Blue;
                else
                    color = Color.Black;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
