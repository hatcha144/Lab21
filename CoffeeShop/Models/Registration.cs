using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Registration
    {
        public string prefix { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string streetNum { get; set; }
        public string streetName { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
    }
}