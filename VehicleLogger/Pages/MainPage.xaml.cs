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
using VehicleLogger.Windows;

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

        List<VehicleModel> vehicle = new List<VehicleModel>();

        //Click Events
        private void AddNewVehicleButton(object sender, RoutedEventArgs e)
        {
            NewVehicleWindow newVehWindow = new NewVehicleWindow();
            newVehWindow.ShowDialog();
        }

        private void FuelClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FuelPage());
        }

        private void CostsClick(object sender, RoutedEventArgs e)
        {

        }

        private void CalendarClick(object sender, RoutedEventArgs e)
        {

        }

        private void InformationClick(object sender, RoutedEventArgs e)
        {

        }

        private void ReportsClick(object sender, RoutedEventArgs e)
        {

        }

        private void SettingsClick(object sender, RoutedEventArgs e)
        {

        }

       //Functional Methods

        private void LoadVehicleList()
        {
            vehicle = SQLiteDataAccess.LoadVehicles();
            VehiclesCB.ItemsSource = vehicle;
            VehiclesCB.SelectedIndex = 0;
        }

        
    }
}
