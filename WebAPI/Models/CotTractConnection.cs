using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CotTractConnection
    {
        public int Id { get; set; }
        public string CotId { get; set; }
        public string TractId { get; set; }
    }
}
