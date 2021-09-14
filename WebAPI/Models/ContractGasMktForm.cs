using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class ContractGasMktForm
    {
        public int Id { get; set; }
        public string PriceSettlement { get; set; }
        public string Fees { get; set; }
        public string CountyId { get; set; }
        public bool PriceRedeterminationClause { get; set; }
        public DateTime PriceRedeterminationDate { get; set; }
    }
}
