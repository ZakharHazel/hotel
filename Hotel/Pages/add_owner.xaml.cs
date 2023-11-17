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
using Xceed.Wpf.Toolkit;

namespace Hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для add_owner.xaml
    /// </summary>
    public partial class add_owner : Page
    {
        public add_owner()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new owner());
        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            
            if (ZooHotel_Entities.Get().Pets.Count(x => x.Passport == pasport_box.Text) > 0)
            {
                System.Windows.MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                Owners userobj = new Owners()
                {
                    Name = name_box.Text,
                    Surname = surname_box.Text,
                    Patronymic = patronymic_box.Text,
                    Passport = pasport_box.Text,
                    Adress = adress_box.Text,
                    Phone = phone_box.Text,
                };
                ZooHotel_Entities.Get().Owners.Add(userobj);
                ZooHotel_Entities.Get().SaveChanges();
                this.NavigationService.Navigate(new owner());
            }
            catch
            {
                System.Windows.MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
