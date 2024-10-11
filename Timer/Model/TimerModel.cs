using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class TimerModel
    {
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        public void Reset()
        {
            Time = TimeSpan.Zero;
        }

        public void AddHour()
        {
            Time = Time.Add(TimeSpan.FromHours(1));
        }

        public void AddMinute()
        {
            Time = Time.Add(TimeSpan.FromMinutes(1));
        }

        public void AddSecond()
        {
            Time = Time.Add(TimeSpan.FromSeconds(1));
        }

        public void SubtractHour()
        {
            if (Time.TotalHours >= 1)
                Time = Time.Subtract(TimeSpan.FromHours(1));
        }

        public void SubtractMinute()
        {
            if (Time.TotalMinutes >= 1)
                Time = Time.Subtract(TimeSpan.FromMinutes(1));
        }

        public void SubtractSecond()
        {
            if (Time.TotalSeconds >= 1)
                Time = Time.Subtract(TimeSpan.FromSeconds(1));
        }
    }
}
