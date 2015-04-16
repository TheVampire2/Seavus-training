using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrinciple.TheGood
{
    /// <summary>
    /// runner that runs faster that fast runner
    /// </summary>
    public class FasterRunner : Runner
    {
        public override int getSpeed()
        {
            return Races * 30;
        }
    }
   
}
