using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class NewPayment
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string PropertyId { get; set; }
        public string TractId { get; set; }
        public string SubTractId { get; set; }
        public string PayeeId { get; set; }
        public string PaymentType { get; set; }
        public DateTime DueDate { get; set; }
        public int Period { get; set; }
        public string NetAmountDue { get; set; }
        public string SuspenseCode { get; set; }
        public string PayLessorDirect { get; set; }
        public string IncludeNotesOnDeck { get; set; }
        public string ResponsiblePartyId { get; set; }
        public string LegalDescription { get; set; }
        public string BankId { get; set; }
        public string BankAccountNo { get; set; }
        public string BankFees { get; set; }
    }
}
