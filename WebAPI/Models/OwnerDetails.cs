using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class OwnerDetails
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string FullName { get; set; }
    }
}
