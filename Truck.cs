using System.Collections.Generic;

namespace EvrazTestProject
{
    /// <summary>
    /// Грузовик
    /// </summary>
    class Truck : Vehicle
    {
        #region Properties
        public override string Type => "Грузовик";
        /// <summary>
        /// Вес груза
        /// </summary>
        public float CargoWeight => _cargoWeight;
        /// <summary>
        /// Все характеристики транспорта
        /// </summary>
        public override Dictionary<string, object> AllProperties => new Dictionary<string, object> {
            { "Скорость", _speed },
            { "Шанс прокола шины", _punctureChance },
            { "Вес груза", _cargoWeight },
        };
        #endregion

        private float _cargoWeight;


        /// <summary>
        /// Грузовик
        /// </summary>
        /// <param name="goalDistance">Целевое расстояние</param>
        /// <param name="speed">Скорость в м/с</param>
        /// <param name="punctureChance">Шанс прокола шины</param>
        /// <param name="minPunctureTime">Минимальное время прокола шины</param>
        /// <param name="maxPunctureTime">Максимальное время прокола шины</param>
        /// <param name="cargoWeight">Вес груза</param>
        public Truck(float goalDistance, float speed, float punctureChance, int minPunctureTime, int maxPunctureTime, float cargoWeight)
        {
            _goalDistance = goalDistance;
            _speed = speed;
            _punctureChance = punctureChance;
            _minPunctureTime = minPunctureTime;
            _maxPunctureTime = maxPunctureTime;
            _cargoWeight = cargoWeight;
        }

        /// <summary>
        /// Обновить статус
        /// </summary>
        public override void RefreshStatus()
        {
            base.RefreshStatus();

            Utils.AddNewLineToString(ref _status, $"Вес груза: {_cargoWeight}");
        }
    }
}