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

namespace Hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для main_manager.xaml
    /// </summary>
    public partial class main_manager : Page
    {
        public main_manager()
        {
            InitializeComponent();
        }

        private void btnpet_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pet());
        }

        private void btnowner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new owner());
        }

        private void btncat_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new categorie());
        }

        private void btncontract_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new contract());
        }
    }
}
