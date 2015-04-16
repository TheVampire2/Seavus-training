using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrinciple.TheGood
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
        /// Returns speed of racer
        /// </summary>
        /// <returns></returns>
        public virtual int getSpeed()
        {
            return Races * 5;
        }
    }
   

    
    

}
