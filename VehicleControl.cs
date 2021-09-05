﻿using System;
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

            ProgressBar.Maximum = (int)_vehicle.GoalDistance;

            UpdatePropertiesTable();

            _updateAction = () =>
            {
                TypeLabel.Text = _vehicle.Type;
                ProgressBar.Value = (int)_vehicle.ElapsedDistance;

                PunctureLabel.Visible = _vehicle.IsPunctured;
                PunctureLabel.Text = _vehicle.ElapsedDistance.ToString();

                Debug.WriteLine(_vehicle.IsPunctured);

                if (_vehicle.IsPunctured)
                {

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