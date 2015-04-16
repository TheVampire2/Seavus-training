using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrinciple.TheGood
{
    /// <summary>
    /// runner that runs faster than usual runner
    /// </summary>
    public class FastRunner : Runner
    {
        public int Titles { get; set; }
        public override int getSpeed()
        {
            return Races * 10 + Titles*2;
        }
    }
}
