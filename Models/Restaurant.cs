using System;

namespace foodies.Models
{
    public partial class Restaurant
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Latitude {get; set;}
        public decimal Longitude {get; set;}
        public int Rating {get; set;} 
    }
}