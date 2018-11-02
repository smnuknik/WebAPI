using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Descritption { get; set; }
        public int? Price { get; set; }
        public int? Unitperprice { get; set; }
        public short? Status { get; set; }
        public string UnitCode { get; set; }
        public string CatCode { get; set; }
    }
}
