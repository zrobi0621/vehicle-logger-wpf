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
    /// Interaction logic for FuelPage.xaml
    /// </summary>
    public partial class FuelPage : Page
    {
        public FuelPage()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        List<FuelModel> fuels = new List<FuelModel>();

        //Click events

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //Functional Methods

        public void RefreshDataGrid()
        {
            fuels = SQLiteDataAccess.LoadFuels();
            FuelDataGrid.ItemsSource = null;
            FuelDataGrid.ItemsSource = fuels;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
    }
}
