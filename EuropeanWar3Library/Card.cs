using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanWar3Library
{
    [FlagsAttribute]
    public enum Card
    {
        none = 0x00,
        assaultart = 0x01,
        defendart = 0x02,
        carrier = 0x04,
        commander = 0x08,
    }
}
