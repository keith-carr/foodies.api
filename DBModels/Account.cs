using System;
using System.Collections.Generic;

namespace foodies.DBModels
{
    public partial class Account
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLogin { get; set; }
        public string NewOtherItem {get; set;}
    }
    
}
