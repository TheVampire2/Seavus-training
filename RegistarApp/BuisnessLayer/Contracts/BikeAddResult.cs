using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
namespace BuisnessLayer.Contracts
{
    public class BikeAddResult : CommandResult
    {
        public Bike BikeAdded { get; set; }

    }
}
