using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Models
{
    public class CustomerViewModel
    {
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string RegIpAddress { get; set; }
        public int ID { get; set; }
        public string date_created { get; set; }
        public int Address_Count { get; set; }
        public int Attribute_Count { get; set; }

    }
}