using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistarApp.Models
{
    public class Bike
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Type { get; set; }

        public Bike(string name, int rating, string type)
        {
            Name = name;
            Rating = rating;
            Type = type;
        }
    }
}