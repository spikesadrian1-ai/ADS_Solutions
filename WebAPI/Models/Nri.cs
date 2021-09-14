using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Nri
    {
        public int Id { get; set; }
        public string LeaseId { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public decimal? WorkingInterest { get; set; }
        public string LeaseWorking { get; set; }
        public decimal? Nri1 { get; set; }
        public string WellId { get; set; }
        public string OwnerId { get; set; }
    }
}
