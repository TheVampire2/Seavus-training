using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.TheGood
{
     /// <summary>
    /// Man that run very fast
    /// </summary>
    public class Runner : IPowerWorkout,IMotivate
    {
       
        /// <summary>
        /// Sending the runner to power workout
        /// </summary>
        public virtual void PowerWorkout()
        {
            Console.WriteLine(" HARD POWER WORKOUT! POWER ++++++++++++ ");
           
        }
        /// <summary>
        /// Motivating the runner
        /// </summary>
        public virtual void Motivate()
        {
            Console.WriteLine(" Motivational speech of the coach! MOTIVATION +++++++++++++++++");
        }
        
        
    }
}
