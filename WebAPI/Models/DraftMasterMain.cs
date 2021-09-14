using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class DraftMasterMain
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string PropertyId { get; set; }
        public string DraftNo { get; set; }
        public DateTime DraftDate { get; set; }
        public string PayeeId { get; set; }
        public string BankIdNo { get; set; }
        public decimal DraftAmount { get; set; }
        public decimal BankFees { get; set; }
        public int DueDays { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaidById { get; set; }
        public string DraftFormId { get; set; }
    }
}
