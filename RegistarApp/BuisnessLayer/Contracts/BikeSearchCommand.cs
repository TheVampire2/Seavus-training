using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Contracts
{
    public class BikeSearchCommand : Command
    {
        /// <summary>
        /// Let us search by any of the properties defined
        /// </summary>

        public string Producer { get; set; }
        public int RegNum { get; set; }
        public string Type { get; set; }

        public DateTime ProduceDate { get; set; }

        public string Colour { get; set; }

        public string City { get; set; }
        
        /// <summary>
        /// Paging property -size of page
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Paging property -index of page
        /// </summary>
        public int PageIndex { get; set; }

    }
}
