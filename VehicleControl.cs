using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class VehicleControl : UserControl
    {
        private Vehicle _vehicle;

        public VehicleControl(Vehicle vehicle)
        {
            InitializeComponent();

            _vehicle = vehicle;
            _vehicle.Updated += UpdateControl;

            ProgressBar.Maximum = (int)_vehicle.GoalDistance;

            UpdatePropertiesTable();
        }

        private void UpdateControl()
        {
            Action action = () =>
            {
                TypeLabel.Text = _vehicle.Type;
                ProgressBar.Value = (int)_vehicle.ElapsedDistance;

                PunctureLabel.Visible = _vehicle.IsPunctured;

                //UpdatePropertiesTable();
            };
            Invoke(action);
        }

        private void UpdatePropertiesTable()
        {
            foreach (KeyValuePair<string, object> property in _vehicle.AllProperties)
            {
                PropertiesTable.Rows.Add(property.Key, property.Value);
                PropertiesTable.Rows.Add(property.Key, property.Value);
            }
        }
    }
}