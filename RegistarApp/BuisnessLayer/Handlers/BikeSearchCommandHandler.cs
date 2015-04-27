using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DomainModel;

namespace BuisnessLayer.Contracts.Handlers
{
    /// <summary>
    /// Class for implementing specific Command Handler
    /// </summary>
    class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand, BikeSearchResult>
    {
        /// <summary>
        /// context is injected with constructor
        /// </summary>
        private IRegistarContext context;
        public BikeSearchCommandHandler()
        {
            context = new RegistarDbContext();
        }
        public BikeSearchCommandHandler(IRegistarContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// The real buisnes logic for the command 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            ///We're using " USING " because using of DbContext opens up a connection to database and it must be managed ( closed when needed ) 
            ///and we cant completly rely on the garbage collector 
            
            ///This DbContext should and will be injected dinamicly later
          
                IEnumerable<Bike> bikes = new List<Bike>();
                
                /// This query is executed when the "bikes" is first used 
                /// or in this situation when the ".ToList() is called, or when itteration is needed
                /// LazyLoad --> the query is executed only when the informations are needed to be used 
               // bikes = context.Bikes.OrderBy(p => p.BikeId)
                //                     .Take(10)
              //                       .ToList<Bike>();4

               
                if (context != null)
                {
                    //using diferent syntax from above
                    var query = from b in context.Bikes
                                select b;
                    // Some cool thins that Entity is capable of
                    // Concatening of multiple queries

                    if (!string.IsNullOrEmpty(command.Colour))
                    {
                        query = query.Where(x => x.Colour == command.Colour);
                    }
                    if (command.RegNum > 0)
                    {
                        query = query.Where(x => x.RegNum == command.RegNum);
                    }
                    //Skip and Take are used for paging
                    query = query.OrderBy(x => x.BikeId);
                    //  .Skip(command.PageIndex * command.PageSize)
                    //  .Take(command.PageSize);

                    BikeSearchResult result = new BikeSearchResult();

                    /// And this is when the query is executed 
                    result.Result = query.ToList();
                    return result;
                }
                return null;
        }
    }
}
