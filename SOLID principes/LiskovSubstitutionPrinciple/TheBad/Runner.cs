using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.TheBad
{
     /// <summary>
    /// Man that run very fast
    /// </summary>
    public class Runner
    {
    
        /// <summary>
        /// Sending the runner to power workout
        /// </summary>
        public virtual void PowerWorkout()
        {
            Console.WriteLine(" HARD POWER WORKOUT! ");
            
        }
        /// <summary>
        /// Motivating the runner
        /// </summary>
        public virtual void Motivate()
        {
            Console.WriteLine(" Motivational speech of the coach ");
          
        }
        
    }
}
