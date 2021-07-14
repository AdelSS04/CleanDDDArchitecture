using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Timing
{
    public interface IClockProvider
    {
        DateTime Now { get; }

        DateTimeKind Kind { get; }

        bool SupportsMultipleTimezone { get; }

        DateTime Normalize(DateTime dateTime);

    }
}
