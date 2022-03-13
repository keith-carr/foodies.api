using System;

namespace Foodies.API.Models
{
    public class Restaurant
    {
        public int Id {get; set;}
        public string name {get; set;}
        public decimal latitude {get; set;}
        public decimal longitude {get; set;}
        public int rating {get; set;} 
    }
}