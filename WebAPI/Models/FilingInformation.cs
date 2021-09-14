using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class FilingInformation
    {
        public int Id { get; set; }
        public DateTime? FilingDate { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string Book { get; set; }
        public string Page { get; set; }
        public string Volume { get; set; }
        public string Entry { get; set; }
        public string Other { get; set; }
        public string QuickNote { get; set; }
        public string CotId { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public string GrantorId { get; set; }
        public string GranteeId { get; set; }
    }
}
