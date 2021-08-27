namespace EvrazTestProject
{
    class Car : Vehicle
    {
        private int _passengersCount;
        public int PassengersCount => _passengersCount;

        public Car(float speed,float punctureChance,int passengersCount)
        {
            _speed = speed;
            _punctureChance = punctureChance;
            _passengersCount = passengersCount;
        }
    }
}