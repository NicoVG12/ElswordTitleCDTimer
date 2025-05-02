using HoraryClock;
using System.Runtime.CompilerServices;

namespace Clock
{
    public class ClockManager
    {
        private object _lock = new object();
        private DateTime LastCheck { get; set; }
        public bool IsRunning { get; private set; }
        public double ElapsedTime { get; set; }
        public double TotalTime {  get; set; }
        public int RefreshDelay { get; set; } = 10;
        private Config Config { get; set; } = Config.Instance();

        private ClockManager()
        {
            IsRunning = false;
        }

        public ClockManager(int totalTime)
        {
            IsRunning = false;
            TotalTime = totalTime;

        }

        public async Task StartAsync()
        {
            if (!IsRunning)
            {
                LastCheck = DateTime.Now;
                IsRunning = true;
                while (IsRunning)
                {
                    lock (_lock)
                    {
                        DateTime newCheck = DateTime.Now;
                        ElapsedTime += ((newCheck - LastCheck).TotalMilliseconds);
                        LastCheck = newCheck;


                        if (ElapsedTime >= TotalTime)
                        {
                            ElapsedTime = 0;
                            Pause();
                        }
                    }
                    await Task.Delay(RefreshDelay);
                }
            }
        }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Reset()
        {
            if (!(Config.StartClockOnReset == Config.CHECKED))
            {
                Pause();
            }
            else
            {
                Task.Run(() => StartAsync());
            }
            ElapsedTime = 0;
        }


    }
}