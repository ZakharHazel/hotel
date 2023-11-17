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
    /// Логика взаимодействия для contract_detail.xaml
    /// </summary>
    public partial class contract_detail : Page
    {
        public contract_detail(int id_con)
        {
            InitializeComponent();
            var userobj = ZooHotel_Entities.Get().Contracts.FirstOrDefault(x => x.id == id_con);
            id_box.Text= userobj.id.ToString();
            date_box.Text = userobj.Date.ToString();
            owner_box.Text = userobj.Owner_id.ToString();
            price_box.Text = userobj.Price.ToString();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new contract());
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
