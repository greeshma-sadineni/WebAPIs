using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_with_WebApi.Entities
{
    public class Customer
    {
        [Required]
        public int Id { set; get; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }
     

    }
}
