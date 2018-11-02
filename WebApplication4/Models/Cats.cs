using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public partial class Cats
    {
        public Cats()
        {
            products = new HashSet<Product>();
        }
        [Key]
        public string CatId { get; set; }
        public string CatName { get; set; }

        public ICollection<Product> products { get; set; }

    }
}
