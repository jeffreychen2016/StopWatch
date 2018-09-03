using System;

namespace StopWatch
{
    public class Watch
    {
        private DateTime _clickInTime;
        private DateTime _clockOutTime;

        public void start()
        {
            _clickInTime = DateTime.Now;
        }

        public void stop()
        {
            _clockOutTime = DateTime.Now;

            getDuration(_clickInTime, _clockOutTime);
        }

        private void getDuration(DateTime clockInTime, DateTime clockOutTime)
        {
            var duration = clockOutTime - clockInTime;
            Console.WriteLine($"Duration: {duration}");
        }
    }
}
