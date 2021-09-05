using System.Collections.Generic;
using System.Windows.Forms;

namespace EvrazTestProject
{
    public partial class Rating : Form
    {
        public Rating(List<VehicleRating> ratingList)
        {
            InitializeComponent();

            foreach (VehicleRating rating in ratingList)
            {
                RatingTable.Rows.Add(rating.Vehicle.Type, rating.Time);
            }
        }
    }
}