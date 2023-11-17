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
using System.Xml.Linq;

namespace Hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для add_staff.xaml
    /// </summary>
    public partial class add_staff : Page
    {
        public add_staff()
        {
            InitializeComponent();
            rol_box.ItemsSource = ZooHotel_Staff_Entities.Get().Roles.ToList();
        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            string _NameRole;
            int _idRole;
            if (ZooHotel_Staff_Entities.Get().Staffs.Count(x => x.login == login_box.Text) > 0)
            {
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                _NameRole = rol_box.Text;
                var RoleOdj = ZooHotel_Staff_Entities.Get().Roles.FirstOrDefault(x => x.name == _NameRole);
                _idRole = RoleOdj.id;

                Staffs userobj = new Staffs()
                {
                    login = login_box.Text,
                    name = name_box.Text,
                    passoword =pass_box.Text,
                    role_id = _idRole
                };
                ZooHotel_Staff_Entities.Get().Staffs.Add(userobj);
                ZooHotel_Staff_Entities.Get().SaveChanges();
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.Navigate(new root_panel());
            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
