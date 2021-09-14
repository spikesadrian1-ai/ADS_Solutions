using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class DoideckDetails
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string InterestType { get; set; }
        public string Interest { get; set; }
        public string SuspenseCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? OtherDate { get; set; }
        public string InterestFormula { get; set; }
        public string PayRegardless { get; set; }
        public string NoPay { get; set; }
        public string PayWpt { get; set; }
        public string PaySeveranceTax { get; set; }
        public string Active { get; set; }
        public string PayMarketingCosts { get; set; }
        public string PayOtherTax1 { get; set; }
        public string PayOtherTax2 { get; set; }
        public string WellId { get; set; }
    }
}
