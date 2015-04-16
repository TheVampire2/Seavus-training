using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrinciple.TheGood
{
    /// <summary>
    /// runner that runs faster than vey fast runner
    /// </summary>
    public class FastestRunner : FasterRunner
    {
        public int WorldWideExpirience { get; set; }
        public override int getSpeed()
        {
            return base.getSpeed() + WorldWideExpirience * 2;
        }
    }
}
