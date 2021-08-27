namespace EvrazTestProject
{
    class Truck : Vehicle
    {
        private float _cargoWeight;
        public float CargoWeight => _cargoWeight;

        public Truck(float speed, float punctureChance, float cargoWeight)
        {
            _speed = speed;
            _punctureChance = punctureChance;
            _cargoWeight = cargoWeight;
        }

        public override void RefreshStatus()
        {
            base.RefreshStatus();

            Utils.AddNewLineToString(ref _status, $"Вес груза: {_cargoWeight}");
        }
    }
}