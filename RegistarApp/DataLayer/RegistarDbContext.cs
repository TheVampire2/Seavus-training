using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RegistarDbContext : DbContext,IRegistarContext
    {
        public IDbSet<Bike> Bikes { get; set; }

        /// <summary>
        /// : base(ime na connection string) isto treba da stoi i vo connection string name 
        /// </summary>
        public RegistarDbContext() : base("RegistarDb")
        {
            Bikes = Set<Bike>();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
        }


        
    }
}
