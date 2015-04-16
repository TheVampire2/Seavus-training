using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.TheBad
{
    /// <summary>
    /// Rookie runner, runner that is fresh in running sport
    /// </summary>
    public class RookieRunner : Runner
    {
        public override void PowerWorkout()
        {
            throw new Exception("WHY THE FU*CK YOU SENDING ME TO POWER WORKOUT, IM STILL A ROOKIE !!! ");
        }
        public override void Motivate()
        {
            Console.WriteLine(" Motivational speech of the coach ");
        }
        
    }
}
