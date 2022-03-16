
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace foodies.Models
{
    public partial class Account
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLogin { get; set; }
    }    
}
