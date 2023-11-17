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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new start());
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userobj = ZooHotel_Staff_Entities.Get().Staffs.FirstOrDefault(x => x.login == login_box.Text && x.passoword == Pass_box.Password);
                if (userobj == null)
                {
                    MessageBox.Show("Пользователь с таким логином и паролем не найден!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userobj.role_id)
                    {
                        case 1:
                            this.NavigationService.Navigate(new root_panel());
                            break;
                        case 2:
                            this.NavigationService.Navigate(new main_manager());
                            break;
                    }
                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ouбica:" + Ex.Message.ToString(), "Kpaтaveckая рабoта прилоxen", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
