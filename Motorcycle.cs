namespace EvrazTestProject
{
    /// <summary>
    /// Мотоцикл с коляской
    /// </summary>
    class Motorcycle : Vehicle
    {
        #region Properties
        /// <summary>
        /// Наличие коляски
        /// </summary>
        public bool HasSidecar => _hasSidecar;
        #endregion

        private bool _hasSidecar;


        /// <summary>
        /// Мотоцикл с коляской
        /// </summary>
        /// <param name="goalDistance">Целевое расстояние</param>
        /// <param name="speed">Скорость в м/с</param>
        /// <param name="punctureChance">Шанс прокола шины</param>
        /// <param name="minPunctureTime">Минимальное время прокола шины</param>
        /// <param name="maxPunctureTime">Максимальное время прокола шины</param>
        /// <param name="hasSideCar">Наличие коляски</param>
        public Motorcycle(float goalDistance, float speed, float punctureChance, int minPunctureTime, int maxPunctureTime, bool hasSideCar)
        {
            _goalDistance = goalDistance;
            _speed = speed;
            _punctureChance = punctureChance;
            _minPunctureTime = minPunctureTime;
            _maxPunctureTime = maxPunctureTime;
            _hasSidecar = hasSideCar;
        }

        /// <summary>
        /// Обновить статус
        /// </summary>
        public override void RefreshStatus()
        {
            base.RefreshStatus();

            Utils.AddNewLineToString(ref _status, $"Наличие коляски: {(_hasSidecar ? "Да" : "Нет")}");
        }
    }
}