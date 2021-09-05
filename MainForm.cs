using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class MainForm : Form
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();

        private List<VehicleRating> _vehiclesRating = new List<VehicleRating>();

        private Dictionary<string, Type> _vehicleTypes = new Dictionary<string, Type>()
        {
            {"Легковой автомобиль", typeof(Car) },
            {"Грузовик", typeof(Truck) },
            {"Мотоцикл", typeof(Motorcycle) },
        };

        private Stopwatch _stopwatch = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            foreach(string type in _vehicleTypes.Keys)
            {
                TypeComboBox.Items.Add(type);
            }
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;



            /*
            Truck truck = new Truck(100, 25, 50, 0, 5, 100);

            VehicleControl vc = new VehicleControl(truck);
            VehiclesContainer.Controls.Add(vc);

            truck.Start();
            */
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassengersCountLabel.Visible = TypeComboBox.SelectedItem.ToString() == "Легковой автомобиль";
            PassengersCountTextBox.Visible = TypeComboBox.SelectedItem.ToString() == "Легковой автомобиль";

            SideCarCheckBox.Visible = TypeComboBox.SelectedItem.ToString() == "Мотоцикл";

            CargoWeightLabel.Visible = TypeComboBox.SelectedItem.ToString() == "Грузовик";
            CargoWeightTextBox.Visible = TypeComboBox.SelectedItem.ToString() == "Грузовик";
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            Type vehicleType = _vehicleTypes[TypeComboBox.SelectedItem.ToString()];
            Vehicle createdVehicle = null;

            switch (vehicleType.Name)
            {
                case "Car":
                    Car newCar = new Car(
                        float.Parse(DistanceTextBox.Text),
                        float.Parse(SpeedTextBox.Text),
                        float.Parse(PunctureChanceTextBox.Text),
                        int.Parse(MinPunctureTimeTextBox.Text),
                        int.Parse(MaxPunctureTimeTextBox.Text),
                        int.Parse(PassengersCountTextBox.Text));

                    createdVehicle = newCar;

                    _vehicles.Add(newCar);
                    break;

                case "Truck":
                    Truck newTruck = new Truck(
                        float.Parse(DistanceTextBox.Text),
                        float.Parse(SpeedTextBox.Text),
                        float.Parse(PunctureChanceTextBox.Text),
                        int.Parse(MinPunctureTimeTextBox.Text),
                        int.Parse(MaxPunctureTimeTextBox.Text),
                        float.Parse(PassengersCountTextBox.Text));

                    createdVehicle = newTruck;

                    _vehicles.Add(newTruck);
                    break;

                case "Motorcycle":
                    Motorcycle newMotorcycle = new Motorcycle(
                        float.Parse(DistanceTextBox.Text),
                        float.Parse(SpeedTextBox.Text),
                        float.Parse(PunctureChanceTextBox.Text),
                        int.Parse(MinPunctureTimeTextBox.Text),
                        int.Parse(MaxPunctureTimeTextBox.Text),
                        SideCarCheckBox.Checked);

                    createdVehicle = newMotorcycle;

                    _vehicles.Add(newMotorcycle);
                    break;
            }

            createdVehicle.OnFinish += () =>
            {
                _vehiclesRating.Add(new VehicleRating(createdVehicle, _stopwatch.ElapsedMilliseconds / 1000f));

                if (_vehiclesRating.Count == _vehicles.Count)
                {
                    Rating rating = new Rating(_vehiclesRating);
                    rating.ShowDialog();
                }
            };

            VehicleControl vc = new VehicleControl(createdVehicle);
            VehiclesContainer.Controls.Add(vc);
        }

        private void StartRaceButton_Click(object sender, EventArgs e)
        {
            if (_vehicles.Count > 0)
            {
                _stopwatch.Start();

                foreach(Vehicle vehicle in _vehicles)
                {
                    vehicle.Start();
                }
            }
        }
    }
}