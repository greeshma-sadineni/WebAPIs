using System;
using System.Collections.Generic;

namespace WebApi_With_Enity_Framework.Models
{
    public partial class ProductCategories
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
