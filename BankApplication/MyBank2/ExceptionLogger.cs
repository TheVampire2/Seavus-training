using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank2
{
    /// <summary>
    /// Exception logger class
    /// </summary>
    public static class ExceptionLogger
    {
        public static void LogException(Exception e){

            Console.WriteLine("Exception message: " + e.Message + ", Inner exception: " + e.InnerException);

        }
    }
}
