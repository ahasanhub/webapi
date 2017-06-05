using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Api.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PromoCode { get; set; }
    }
}