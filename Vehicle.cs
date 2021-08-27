using System;
using System.Diagnostics;
using System.Threading;

namespace EvrazTestProject
{
    abstract class Vehicle
    {
        protected float _speed;
        public float Speed => _speed;

        protected float _punctureChance;
        public float PunctureChance => _punctureChance;

        protected string _status;
        public string Status => _status;

        Process process;

        DateTime startTime;
        DateTime currentTime;

        public virtual void RefreshStatus()
        {
            _status = string.Empty;

            Utils.AddNewLineToString(ref _status, $"Скорость: {_speed}");
            Utils.AddNewLineToString(ref _status, $"Вероятность прокола: {_punctureChance}");
        }

        public void Start()
        {
            process = Process.GetCurrentProcess();

            startTime = process.StartTime.ToUniversalTime();

            Thread someThread = new Thread(Tick);
            someThread.IsBackground = true;
            someThread.Start();
        }

        private void Tick()
        {
            int current = 0;

            while (true)
            {
                Thread.Sleep(1);

                currentTime = DateTime.UtcNow + process.TotalProcessorTime;

                Debug.WriteLine(currentTime - startTime);

                current++;
            }
        }
    }
}