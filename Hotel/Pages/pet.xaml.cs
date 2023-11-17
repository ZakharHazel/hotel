using Hotel.application;
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
    /// Логика взаимодействия для pet.xaml
    /// </summary>
    public partial class pet : Page
    {
        public pet()
        {
            InitializeComponent();
            gridpet.ItemsSource = ZooHotel_Entities.Get().Pets.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new add_pet());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var Removing = gridpet.SelectedItems.Cast<Pets>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ZooHotel_Entities.Get().Pets.RemoveRange(Removing);
                    ZooHotel_Entities.Get().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    gridpet.ItemsSource = ZooHotel_Entities.Get().Pets.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new main_manager());
        }
    }
}
