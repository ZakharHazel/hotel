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
    /// Логика взаимодействия для categorie.xaml
    /// </summary>
    public partial class categorie : Page
    {
        public categorie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new add_categorie());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var Removing = gridcat.SelectedItems.Cast<Categories>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ZooHotel_Entities.Get().Categories.RemoveRange(Removing);
                    ZooHotel_Entities.Get().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    gridcat.ItemsSource = ZooHotel_Entities.Get().Categories.ToList();
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
