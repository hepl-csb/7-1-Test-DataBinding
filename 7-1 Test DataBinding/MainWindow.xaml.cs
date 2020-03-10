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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7_1_Test_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AgeTB.Text = "0"; // Initialiser le contenu de la TextBox
    }

    private void VieillirButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            // Lire le contenu de la TextBox, convertir la donnée en nombre entier avant de calculer le nouvel age
            int age = Convert.ToInt32(AgeTB.Text) + 1;
            AgeTB.Text = age.ToString();
        }
        catch (Exception exc)
        {
            MessageBox.Show("Erreur d'age : " + exc.Message);
        }
    }
}
}
