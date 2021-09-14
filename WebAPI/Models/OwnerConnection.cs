using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class OwnerConnection
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string SuaId { get; set; }
        public string RowId { get; set; }
        public string EasementId { get; set; }
    }
}
