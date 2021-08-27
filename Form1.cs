using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Truck some = new Truck(1, 1, 1);

            some.Start();
        }
    }
}