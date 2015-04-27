using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Contracts
{
    public class BikeAddCommand : Command
    {
        public string Producer { get; set; }
        public int RegNum { get; set; }
        public string Type { get; set; }

        public DateTime ProduceDate { get; set; }

        public string Colour { get; set; }

        public string City { get; set; }

        
    }
}
