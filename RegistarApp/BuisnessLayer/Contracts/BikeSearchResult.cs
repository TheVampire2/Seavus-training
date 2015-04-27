using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Contracts
{
    public class BikeSearchResult : CommandResult
    {
        public List<Bike> Result{ get; set; }
    }
}
