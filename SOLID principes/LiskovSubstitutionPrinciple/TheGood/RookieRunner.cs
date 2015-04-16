using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.TheGood
{
    /// <summary>
    /// Rookie runner, runner that is fresh in running sport
    /// </summary>
    public class RookieRunner : IMotivate
    {

        /// <summary>
        /// Motivating the runner
        /// </summary>
        public void Motivate()
        {
            Console.WriteLine(" Motivational speech of the coach ");
        }
      
    }
}
