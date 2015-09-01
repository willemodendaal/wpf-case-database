using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CaseDatabase.ValueConverters
{
    /// <summary>
    /// Negates a double. For example: 100 becomes -100, or -200 becomes 200.
    /// </summary>
    internal class Negate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(double?))
            {
                throw new InvalidOperationException("TargetType must be of type double.");
            }

            double source = double.Parse(value.ToString());
            return source * -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
