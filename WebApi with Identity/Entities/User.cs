using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_with_Identity.Entities
{
    public class User
    {[Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasttName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] PassWordHash { get; set; }
        [Required]
        public byte[] PassWordSalt { get; set; }
    }
}
