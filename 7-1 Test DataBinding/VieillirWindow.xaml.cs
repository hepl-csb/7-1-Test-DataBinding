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
    /// <summary>
    /// Interaction logic for VieillirWindow.xaml
    /// </summary>
public partial class VieillirWindow : Window
{
    private Personne _currentPersonne;

    private Personne CurrentPersonne
    {
        get { return _currentPersonne; }
        set { _currentPersonne = value; }
    }


    public VieillirWindow()
    {
        InitializeComponent();
        CurrentPersonne = new Personne();
        AgeTB.DataContext = CurrentPersonne;
    }

    private void VieillirButton_Click(object sender, RoutedEventArgs e)
    {
        CurrentPersonne.Vieillir();
    }
}
}
