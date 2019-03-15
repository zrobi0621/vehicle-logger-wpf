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

        List<VehicleModel> vehicles = new List<VehicleModel>();

        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;

        //Click Events
        private void AddNewVehicleButton(object sender, RoutedEventArgs e)
        {

            NewVehicleWindow newVehicleInstance = new NewVehicleWindow();
            RefreshListEvent += new RefreshList(RefreshListView); // event initialization
            newVehicleInstance.UpdateVehicles = RefreshListEvent; // assigning event to the Delegate
            newVehicleInstance.ShowDialog();


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

        public void LoadVehicleList()
        {
            vehicles = SQLiteDataAccess.LoadVehicles();
            VehiclesCB.ItemsSource = null;
            VehiclesCB.ItemsSource = vehicles;
            VehiclesCB.SelectedIndex = 0;
        }

        private void RefreshListView()
        {
            vehicles = SQLiteDataAccess.LoadVehicles();
            VehiclesCB.ItemsSource = null;
            VehiclesCB.ItemsSource = vehicles;
            VehiclesCB.SelectedIndex = 0;
        }


    }
}
