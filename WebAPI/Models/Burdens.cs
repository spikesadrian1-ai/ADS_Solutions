using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Burdens
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string InterestFormula { get; set; }
        public decimal? BurdenInterest { get; set; }
        public bool? FullInterest { get; set; }
        public string BurdenType { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal? BurdenAmount { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public string LeaseId { get; set; }
        public string WellId { get; set; }
        public string RoyId { get; set; }
    }
}
