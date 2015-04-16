using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrinciple.TheBad
{
    /// <summary>
    /// Man that run very fast
    /// </summary>
    public class Runner
    {
        /// <summary>
        /// how many races this racer have won
        /// </summary>
        public int Races { get; set; }
        /// <summary>
        /// type of racer
        /// </summary>
        public int Type { get; set; } // 0 = fast runner, 1 = faster runnder, others = normal runner

        /// <summary>
        /// Returns speed of runner
        /// </summary>
        /// <returns></returns>
        public int getSpeed()
        {
            if (Type == 0)
            {
                return Races * 10;
            }
            if (Type == 1)
            {
                return Races * 30;
            }
            else
                return Races * 5;
        }
    }
}
