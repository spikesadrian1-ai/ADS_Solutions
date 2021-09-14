using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ChainOfTitleForm
    {
        public int Id { get; set; }
        public string InstrumentId { get; set; }
        public string TypeOfInstrument { get; set; }
        public string BriefDescription { get; set; }
        public string Category { get; set; }
        public string Active { get; set; }
        public DateTime? InstrumentDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? OtherDate1 { get; set; }
        public DateTime? OtherDate2 { get; set; }
        public string Conveyance { get; set; }
        public string GrantorInfo { get; set; }
        public string GranteeInfo { get; set; }
        public string CotId { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string Lot { get; set; }
        public string Block { get; set; }
        public string Subdivision { get; set; }
        public string SurveyTwnRngSec { get; set; }
        public string Abstract { get; set; }
        public string Search1 { get; set; }
        public string Search2 { get; set; }
        public string Search3 { get; set; }
        public string Search4 { get; set; }
        public string LegalDescription { get; set; }
    }
}
