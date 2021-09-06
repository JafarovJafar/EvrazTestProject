namespace EvrazTestProject
{
    public class VehicleRating
    {
        public Vehicle Vehicle => _vehicle;
        public float Time => _time;

        private Vehicle _vehicle;
        private float _time;

        public VehicleRating(Vehicle vehicle, float time)
        {
            _vehicle = vehicle;
            _time = time;
        }
    }
}