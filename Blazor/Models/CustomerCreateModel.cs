using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class CustomerCreateModel
    {
     [Required]
         public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password{ set; get; }
    }
}
