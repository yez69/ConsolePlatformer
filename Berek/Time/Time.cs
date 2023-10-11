using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek.Time
{
    internal static class Time
    {
        private static DateTime oldTime = DateTime.Now;
        public static TimeSpan FullDeltaTime { get; private set; }
        public static float DeltaTime { get; private set; }
        public static void Update()
        {
            FullDeltaTime = new TimeSpan(DateTime.Now.Ticks - oldTime.Ticks);
            DeltaTime = (float)FullDeltaTime.TotalMicroseconds;
            oldTime = DateTime.Now;
        }
    }
}
