using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class RegionMasterMainForm
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public string FormationCodes { get; set; }
        public string Active { get; set; }
        public string RegionId { get; set; }
    }
}
