using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class OwnersContactInfo
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Address { get; set; }
        public string AddressType { get; set; }
        public string Business { get; set; }
        public string Home { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
