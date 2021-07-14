using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Timing
{
    public static class Clock
    {
        public static IClockProvider Provider
        {
            get { return _provider; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Can not set Clock.Provider to null!");
                }

                _provider = value;
            }
        }

        private static IClockProvider _provider;
        static Clock()
        {
            Provider = new UnspecifiedClockProvider();
        }


        public static DateTime Now => Provider.Now;

        public static DateTimeKind Kind => Provider.Kind;


        public static bool SupportsMultipleTimezone => Provider.SupportsMultipleTimezone;

        public static DateTime Normalize(DateTime dateTime)
        {
            return Provider.Normalize(dateTime);
        }
    }
}
