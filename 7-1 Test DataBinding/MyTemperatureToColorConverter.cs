using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _7_1_Test_DataBinding
{
    public class MyTemperatureToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convertir une temperature en une couleur si elle dépasse 40 °C
            Console.WriteLine(value.GetType().Name);
            if (System.Convert.ToInt32(value) < 30)
                return "LightGreen";
            else
                return "Red";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
