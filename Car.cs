using System.Collections.Generic;

namespace EvrazTestProject
{
    /// <summary>
    /// Легковая машина
    /// </summary>
    class Car : Vehicle
    {
        #region Properties
        public override string Type => "Автомобиль";
        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int PassengersCount => _passengersCount;
        /// <summary>
        /// Все характеристики транспорта
        /// </summary>
        public override Dictionary<string, object> AllProperties => new Dictionary<string, object> {
            { "Скорость", _speed},
            { "Шанс прокола шины", _punctureChance},
            { "Количество пассажиров", _passengersCount},
        };
        #endregion

        private int _passengersCount;


        /// <summary>
        /// Легковая машина
        /// </summary>
        /// <param name="goalDistance">Целевое расстояние</param>
        /// <param name="speed">Скорость в м/с</param>
        /// <param name="punctureChance">Шанс прокола шины</param>
        /// <param name="minPunctureTime">Минимальное время прокола шины</param>
        /// <param name="maxPunctureTime">Максимальное время прокола шины</param>
        /// <param name="passengersCount">Количество пассажиров</param>
        public Car(float goalDistance, float speed, float punctureChance, int minPunctureTime, int maxPunctureTime, int passengersCount)
        {
            _goalDistance = goalDistance;
            _speed = speed;
            _punctureChance = punctureChance;
            _minPunctureTime = minPunctureTime;
            _maxPunctureTime = maxPunctureTime;
            _passengersCount = passengersCount;
        }

        /// <summary>
        /// Обновить статус
        /// </summary>
        public override void RefreshStatus()
        {
            base.RefreshStatus();

            Utils.AddNewLineToString(ref _status, $"Количество пассажиров: {_passengersCount}");
        }
    }
}