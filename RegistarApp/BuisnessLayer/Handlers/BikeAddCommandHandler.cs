using BuisnessLayer.Contracts;
using BuisnessLayer.Contracts.Handlers;
using DataLayer;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Handlers
{
    class BikeAddCommandHandler : CommandHandlerBase<BikeAddCommand,BikeAddResult>
    {
        private IRegistarContext context;
        public BikeAddCommandHandler()
        {
            context = new RegistarDbContext();
        }
        public BikeAddCommandHandler(IRegistarContext _context)
        {
            this.context = _context;
        }
        public override BikeAddResult ExecuteCommand(BikeAddCommand command)
        {


            if (context != null)
            {

                /// This query is executed when the "bikes" is first used 
                /// or in this situation when the ".ToList() is called, or when itteration is needed
                /// LazyLoad --> the query is executed only when the informations are needed to be used 
                /// 
                /// http://blog.jongallant.com/2012/10/do-i-have-to-call-dispose-on-dbcontext.html
                /// dont need to dispose the context  
            
                Bike entity = new Bike();
                entity.City = command.City;
                entity.RegNum = command.RegNum;
                entity.Colour = command.Colour;
                entity.ProduceDate = command.ProduceDate;
                entity.Type = command.Type;

                BikeAddResult result = new BikeAddResult();
                result.BikeAdded = context.Bikes.Add(entity);
                context.SaveChanges();
                return result;


            }

            return null;

        }

        
    }
}
