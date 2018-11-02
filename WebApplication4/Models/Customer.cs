using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class Customer
    {
        public string Custid { get; set; }
        public short? InitialCode { get; set; }
        public string CustName { get; set; }
        public string CustLastname { get; set; }
        public short? CustType { get; set; }
    }
}
