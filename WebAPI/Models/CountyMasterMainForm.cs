using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CountyMasterMainForm
    {
        public int Id { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string CountyName { get; set; }
    }
}
