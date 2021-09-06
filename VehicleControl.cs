using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class VehicleControl : UserControl
    {
        public Vehicle Vehicle => _vehicle;

        private Vehicle _vehicle;
        private Action _updateAction;

        public delegate void VoidDelegate();
        public VoidDelegate CloseClicked;

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke();
        }

        public void Reset()
        {
            OutputLabel.Visible = false;
            OutputLabel.Text = "ПРОКОЛ";

            TrackBar.Value = 0;
        }
    }
}