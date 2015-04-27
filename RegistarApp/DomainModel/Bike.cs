using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    /// <summary>
    /// Domain model object bike
    /// </summary>
    public class Bike
    {
        /// <summary>
        /// Bike id
        /// </summary>
        public int BikeId { get; set; }

        public string Producer { get; set; }
        public int RegNum { get; set; }
        public string Type { get; set; }

        public DateTime ProduceDate { get; set; }

        public string Colour { get; set; }

        public string City { get; set; }

        /// <summary>
        /// This property will not be mapped by Entity
        /// </summary>
        [NotMapped]
        public object IgnoreMe { get; set; }

        /// <summary>
        /// This property is mapped to a type Timestamp and it is managed by SQL Server
        /// </summary>
        [NotMapped]
        [Timestamp]
        public byte[] TimeStamp { get; set; }
        

    }
}
