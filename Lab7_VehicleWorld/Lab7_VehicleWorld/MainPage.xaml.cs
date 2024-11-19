using Microsoft.Maui.Controls;

namespace Lab7_VehicleWorld
{
    public partial class MainPage : ContentPage
    {
        //dictionary to store vehicl info
        private Dictionary<string, (string imageSource, string fact)> vehicleData;

        public MainPage()
        {
            InitializeComponent();

            vehicleData = new Dictionary<string, (string imageSource, string fact)>()
            {
                { "Car", ("car.png", "Cars were invented in the late 1800s!") },
                { "Motorcycle", ("motorcycle.png", "Motorcycles offer a thrilling riding experience!") },
                { "Bicycle", ("bicycle.png", "Bicycles are a healthy and eco-friendly way to travel!") }
            };
        }

        //event handler: function triggered when user selects a different vehicle type in the Picker element
        private void OnVehicleSelected(object sender, EventArgs e)
        {
            var selectedVehicle = vehiclePicker.SelectedIndex;                                      //stores index of selected item in the Picker
            var vehicleInfo = vehicleData.FirstOrDefault(x => x.Key == vehiclePicker.SelectedItem); //retrieves corresponding vehicle info from dictionary

            if (vehicleInfo.Value != default) // Check if valid selection made
            {
                vehicleImage.Source = vehicleInfo.Value.imageSource;  // Update image source
                vehicleFactLabel.Text = vehicleInfo.Value.fact;       // Update fact text
            }
        }
    }
}
