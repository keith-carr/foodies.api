using System;
using System.Collections.Generic;

namespace foodies.Models
{
    public partial class Address
    {
        public string Id { get; set; }
        public string StreetAddess { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
    
}
