using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class DoimainForm
    {
        public int Id { get; set; }
        public string DoiId { get; set; }
        public string Active { get; set; }
        public string DoiName { get; set; }
        public DateTime? DoiDate { get; set; }
        public string DoiType { get; set; }
        public string CurrentStatus { get; set; }
        public string CurrentOperator { get; set; }
        public string OriginalOperator { get; set; }
        public string UnitId { get; set; }
        public string WellId { get; set; }
        public string UnitCalcType { get; set; }
        public string OpeningStatement { get; set; }
        public string ClosingStatement { get; set; }
    }
}
