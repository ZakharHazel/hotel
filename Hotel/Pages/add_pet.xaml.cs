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
    /// Логика взаимодействия для add_pet.xaml
    /// </summary>
    public partial class add_pet : Page
    {
        public add_pet()
        {
            InitializeComponent();
            type_box.ItemsSource = ZooHotel_Entities.Get().Type_of_animal.ToList();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pet());
        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            string _Nametype;
            int _idtype;
            if (ZooHotel_Entities.Get().Pets.Count(x => x.Passport == pasport_box.Text) > 0)
            {
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                _Nametype = type_box.Text;
                var typeOdj = ZooHotel_Entities.Get().Type_of_animal.FirstOrDefault(x => x.name == _Nametype);
                _idtype = typeOdj.id;

                Pets userobj = new Pets()
                {
                    Name = name_box.Text,
                    Sex = sex_box.Text,
                    Type_animal = _idtype,
                    Passport = pasport_box.Text,
                    Age= Int32.Parse(age_box.Text),
                    Note =note_box.Text,
                };
                ZooHotel_Entities.Get().Pets.Add(userobj);
                ZooHotel_Entities.Get().SaveChanges();
                this.NavigationService.Navigate(new pet());
            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
