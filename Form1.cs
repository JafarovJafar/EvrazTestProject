using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Truck some = new Truck(100, 12, 50, 1, 15, 1);
            some.Start();
        }
    }
}