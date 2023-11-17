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
    /// Логика взаимодействия для contract.xaml
    /// </summary>
    public partial class contract : Page
    {
        public contract()
        {
            InitializeComponent();
            gridcon.ItemsSource = ZooHotel_Entities.Get().Contracts.ToList();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            var Select = gridcon.SelectedItems.Cast<Contracts>().FirstOrDefault();
            int id_con = Select.id;
            this.NavigationService.Navigate(new contract_detail(id_con));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var Removing = gridcon.SelectedItems.Cast<Contracts>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ZooHotel_Entities.Get().Contracts.RemoveRange(Removing);
                    ZooHotel_Entities.Get().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    gridcon.ItemsSource = ZooHotel_Entities.Get().Contracts.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
