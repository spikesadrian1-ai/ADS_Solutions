using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class PropertyTractConnection
    {
        public int Id { get; set; }
        public string PropertyId { get; set; }
        public string Description { get; set; }
        public string PropertyType { get; set; }
        public string TractId { get; set; }
    }
}
