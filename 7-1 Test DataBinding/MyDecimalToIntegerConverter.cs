using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _7_1_Test_DataBinding
{
    public class MyDecimalToIntegerStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Conversion de double vers int string
            string v = System.Convert.ToString(System.Convert.ToInt32(value));
            return v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Conversion de string vers double
            //new NotImplementedException();
            //return null;
            double dbl = System.Convert.ToDouble(value);
            return dbl;
        }
    }
}
