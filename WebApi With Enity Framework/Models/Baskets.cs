using System;
using System.Collections.Generic;

namespace WebApi_With_Enity_Framework.Models
{
    public partial class Baskets
    {
        public Baskets()
        {
            BasketItems = new HashSet<BasketItems>();
        }

        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<BasketItems> BasketItems { get; set; }
    }
}
