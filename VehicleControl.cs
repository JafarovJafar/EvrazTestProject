using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class VehicleControl : UserControl
    {
        private Vehicle _vehicle;
        private Action _updateAction;

        public VehicleControl(Vehicle vehicle)
        {
            InitializeComponent();

            _vehicle = vehicle;
            _vehicle.Updated += UpdateControl;

            TrackBar.Maximum = (int)_vehicle.GoalDistance;

            UpdatePropertiesTable();

            _updateAction = () =>
            {
                TypeLabel.Text = _vehicle.Type;

                OutputLabel.Visible = _vehicle.IsPunctured;

                TrackBar.Value = (int)_vehicle.ElapsedDistance;

                if (_vehicle.Finished)
                {
                    OutputLabel.Visible = true;
                    OutputLabel.Text = "ФИНИШ!!!";
                }
            };
        }

        private void UpdateControl()
        {
            Invoke(_updateAction);
        }

        private void UpdatePropertiesTable()
        {
            foreach (KeyValuePair<string, object> property in _vehicle.AllProperties)
            {
                PropertiesTable.Rows.Add(property.Key, property.Value);
            }
        }
    }
}