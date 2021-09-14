using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class RecordingInformation
    {
        public int Id { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public DateTime? FileDate { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string Book { get; set; }
        public string Page { get; set; }
        public string Volume { get; set; }
        public string Entry { get; set; }
        public string MultiPayments { get; set; }
        public string IncludeTractIdsWithLegalDescription { get; set; }
        public string CreatePaymentHistory { get; set; }
        public string CreateRevenueReceipts { get; set; }
        public string CreateOptionToExtendBonuses { get; set; }
    }
}
