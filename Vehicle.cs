using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace EvrazTestProject
{
    /// <summary>
    /// Абстрактный класс транспорта
    /// </summary>
    public abstract class Vehicle
    {
        #region Properties
        public abstract string Type { get; }
        /// <summary>
        /// Скорость
        /// </summary>
        public float Speed => _speed;
        /// <summary>
        /// Пройденное расстояние
        /// </summary>
        public float ElapsedDistance => _elapsedDistance;
        /// <summary>
        /// Целевое расстояние
        /// </summary>
        public float GoalDistance => _goalDistance;
        /// <summary>
        /// Шанс прокола колеса
        /// </summary>
        public float PunctureChance => _punctureChance;
        /// <summary>
        /// Проколота шина
        /// </summary>
        public bool IsPunctured => _currentState == States.Punctured;
        /// <summary>
        /// Закончил движение
        /// </summary>
        public bool Finished => _finished;
        /// <summary>
        /// Статус
        /// </summary>
        public string Status => _status;
        /// <summary>
        /// Все характеристики транспорта
        /// </summary>
        public abstract Dictionary<string, object> AllProperties { get; }
        #endregion

        protected enum States
        {
            Default,
            Punctured,
            Finished,
        }
        protected States _currentState;

        protected float _speed;
        protected float _elapsedDistance;
        protected float _goalDistance;
        protected float _punctureChance;
        protected bool _finished;
        protected string _status;

        protected int _minPunctureTime = 10;
        protected int _maxPunctureTime = 120;

        private Stopwatch _stopwatch;
        private Thread _driveThread;

        public delegate void VoidDelegate();
        public event VoidDelegate OnFinish; // неправильный нейминг, но Finished уже занято
        public event VoidDelegate Updated;

        public virtual void RefreshStatus()
        {
            _status = string.Empty;

            Utils.AddNewLineToString(ref _status, $"Скорость: {_speed}");
            Utils.AddNewLineToString(ref _status, $"Вероятность прокола: {_punctureChance}");
            Utils.AddNewLineToString(ref _status, $"Пройденное расстояние: {_elapsedDistance}");
        }

        protected void ChangeState(States state)
        {
            _currentState = state;
        }

        public void Start()
        {   
            _driveThread = new Thread(Tick);
            _driveThread.IsBackground = true;
            _driveThread.Start();
        }

        private void Tick()
        {
            float lastPunctureCheckTime = 0;

            Random random = new Random();
            float randomFloat;

            float punctureStartTime = 0;

            _currentState = States.Default;

            _stopwatch = new Stopwatch();
            _stopwatch.Start();

            while (true)
            {
                switch (_currentState)
                {
                    case States.Default:
                        _elapsedDistance = _speed * _stopwatch.ElapsedMilliseconds / 1000f;

                        if (_elapsedDistance >= _goalDistance)
                        {
                            _finished = true;
                        }

                        RefreshStatus();

                        if (_finished)
                        {
                            ChangeState(States.Finished);
                            Updated?.Invoke();
                            OnFinish?.Invoke();
                            return;
                        }

                        if (_stopwatch.Elapsed.Seconds > lastPunctureCheckTime)
                        {
                            lastPunctureCheckTime = _stopwatch.Elapsed.Seconds;

                            randomFloat = random.Next(0, 100);

                            if (randomFloat <= _punctureChance)
                            {
                                punctureStartTime = _stopwatch.Elapsed.Seconds;

                                _stopwatch.Stop();

                                ChangeState(States.Punctured);
                            }
                        }

                        Updated?.Invoke();
                        break;

                    case States.Punctured:

                        int punctureTime = random.Next(_minPunctureTime, _maxPunctureTime);

                        Thread.Sleep(punctureTime * 1000);

                        _stopwatch.Start();

                        ChangeState(States.Default);
                        break;
                }
            }
        }
    
        public void Reset()
        {
            _elapsedDistance = 0;
            _stopwatch.Reset();
            _finished = false;
        }
    }
}