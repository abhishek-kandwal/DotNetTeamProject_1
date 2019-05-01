using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DataServiceModel
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public bool Approved { get; set; }
    }
}
