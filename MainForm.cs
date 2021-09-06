using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class MainForm : Form
    {
        private Rating _ratingForm;

        private List<Vehicle> _vehicles = new List<Vehicle>();

        private List<VehicleRating> _vehiclesRating = new List<VehicleRating>();

        private Dictionary<string, Type> _vehicleTypes = new Dictionary<string, Type>()
        {
            {"Легковой автомобиль", typeof(Car) },
            {"Грузовик", typeof(Truck) },
            {"Мотоцикл", typeof(Motorcycle) },
        };

        private Stopwatch _stopwatch = new Stopwatch();

        private bool _finished;

        private Action _openRatingAction;

        private bool _inited;

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

            _openRatingAction = () =>
            {
                _ratingForm = new Rating(_vehiclesRating);

                _ratingForm.RestartClicked += () =>
                {
                    Debug.WriteLine("CLICKED");
                    _ratingForm.Close();
                    Restart();
                };

                _ratingForm.ShowDialog();
            };
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
                        float.Parse(CargoWeightTextBox.Text));

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
                    _finished = true;
                    Invoke(_openRatingAction);
                }
            };

            VehicleControl vehicleControl = new VehicleControl(createdVehicle);
            VehiclesContainer.Controls.Add(vehicleControl);

            vehicleControl.CloseClicked += () =>
            {
                _vehicles.Remove(vehicleControl.Vehicle);
                VehiclesContainer.Controls.Remove(vehicleControl);
                vehicleControl.Dispose();
            };
        }

        private void StartRaceButton_Click(object sender, EventArgs e)
        {
            if (_inited)
            {
                Restart();
            }
            else
            {
                _inited = true;
            }

            if (_vehicles.Count > 0)
            {
                _stopwatch.Start();

                foreach(Vehicle vehicle in _vehicles)
                {
                    vehicle.Start();
                }
            }
        }

        private void Restart()
        {
            _finished = false;

            _vehiclesRating = new List<VehicleRating>();

            _stopwatch.Reset();

            foreach(VehicleControl vehicle in VehiclesContainer.Controls)
            {
                vehicle.Reset();
                vehicle.Vehicle.Reset();
            }
        }
    }
}