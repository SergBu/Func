using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public static class DateTimeHelper
    {
        private static Func<DateTime> GetNow = () => DateTime.Now;
        private static Func<DateTime> GetNowUtc = () => DateTime.UtcNow;

        public static DateTime Now()
        {
            return GetNow.Invoke();
        }

        public static DateTime UtcNow()
        {
            return GetNowUtc.Invoke();
        }

        public static void OverrideNow(Func<DateTime> newNow)
        {
            GetNow = newNow;
        }
        public static void OverrideNowUtc(Func<DateTime> newNow)
        {
            GetNowUtc = newNow;
        }
    }

}


