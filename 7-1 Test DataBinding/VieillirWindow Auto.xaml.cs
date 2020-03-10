using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _7_1_Test_DataBinding
{
    public partial class VieillirWindowAuto : Window
    {   
        public VieillirWindowAuto()
        {
            InitializeComponent();
        }

        private void VieillirButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentGrid.DataContext is Personne p)
            {
                Console.Write("Age avant = " + p.Age);
                p.Vieillir();
                Console.WriteLine("\tAge après = " + p.Age);
            }
        }
    }
}
