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

namespace VehicleLogger
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            LoadVehicleList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FuelClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FuelPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        List<VehicleModel> vehicle = new List<VehicleModel>();

        private void LoadVehicleList()
        {
            vehicle = SQLiteDataAccess.LoadVehicles();
            VehiclesCB.ItemsSource = vehicle;
            VehiclesCB.SelectedIndex = 0;
        }

        private void ShowDB_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
