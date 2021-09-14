using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class DoideckMain
    {
        public int Id { get; set; }
        public string DeckId { get; set; }
        public string Description { get; set; }
        public string PayoutCode { get; set; }
        public string Product { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string OpeningStatement { get; set; }
        public string ClosingStatement { get; set; }
        public string WellId { get; set; }
        public string OwnerId { get; set; }
    }
}
