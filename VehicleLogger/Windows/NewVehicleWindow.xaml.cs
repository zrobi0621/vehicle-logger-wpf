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
using System.Windows.Shapes;

namespace VehicleLogger.Windows
{
    /// <summary>
    /// Interaction logic for NewVehicleWindow.xaml
    /// </summary>
    public partial class NewVehicleWindow : Window
    {
        public NewVehicleWindow()
        {
            InitializeComponent();
        }

        public Delegate UpdateVehicles;

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            VehicleModel newVehicle;

            if (EngineTextBox.Text == "e.g. AFT 1.6 74KW 101HP or 1600cc" || EngineTextBox.Text == null)
            {
                newVehicle = new VehicleModel(MakeTextBox.Text, ModelTextBox.Text, "NULL", FuelComboBox.SelectedItem.ToString());
            }
            else
            {
                newVehicle = new VehicleModel(MakeTextBox.Text, ModelTextBox.Text, EngineTextBox.Text, FuelComboBox.SelectedItem.ToString());
            }

            SQLiteDataAccess.AddVehicle(newVehicle);

            // Perform save operation 
            UpdateVehicles.DynamicInvoke(); //this will call the `RefreshListView` method of mainWindow
            this.Close();
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
    }
}
