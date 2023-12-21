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
using API_Pokédex.View;

namespace API_Pokédex
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BTN_Rechercher_Click(object sender, RoutedEventArgs e)
        {
            Grid_Affichage.Children.Clear();
            Rechercher my_Rechercher = new Rechercher();
            Grid_Affichage.Children.Add(my_Rechercher);
        }
    }
}
