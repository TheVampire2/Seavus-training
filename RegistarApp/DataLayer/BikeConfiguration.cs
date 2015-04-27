using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// In this class goes the configuration of bike entity 
    /// </summary>
    class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            
            this.ToTable("Bikes","RegistarApp");    
            ///id is combined from 2 columns
          //  this.HasKey(x => new { Id = x.BikeId, Name = x.RegNum });

            ///lambda expression - one row function
            ///preslikuvanje na p vo soodvetno property
            this.Property(p => p.BikeId).HasColumnName("Id");
           /// this.Ignore(x => x.IgnoreMe);
            

        }
    }
}
