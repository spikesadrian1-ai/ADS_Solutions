using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class DistrictMasterMain
    {
        public int Id { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Notes { get; set; }
    }
}
