using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatchModel
    {
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        public void Reset()
        {
            Time = TimeSpan.Zero;
        }
    }
}
