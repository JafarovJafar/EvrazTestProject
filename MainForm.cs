using System.Collections.Generic;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class MainForm : Form
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Truck truck = new Truck(100, 25, 50, 0, 5, 100);

            VehicleControl vc = new VehicleControl(truck);
            VehiclesContainer.Controls.Add(vc);

            truck.Start();
        }
    }
}