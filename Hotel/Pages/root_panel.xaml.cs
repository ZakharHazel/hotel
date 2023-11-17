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
    /// Логика взаимодействия для root_panel.xaml
    /// </summary>
    public partial class root_panel : Page
    {
        public root_panel()
        {
            InitializeComponent();
            gridstaffs.ItemsSource = ZooHotel_Staff_Entities.Get().Staffs.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var Removing = gridstaffs.SelectedItems.Cast<Staffs>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ZooHotel_Staff_Entities.Get().Staffs.RemoveRange(Removing);
                    ZooHotel_Staff_Entities.Get().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    gridstaffs.ItemsSource = ZooHotel_Staff_Entities.Get().Staffs.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new start());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new add_staff());
        }
    }
}
