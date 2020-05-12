using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Status
    {
        public Guid Id { get; set; }
        public int Module { get; set; }
        public string StatusName { get; set; }
        public bool? IsSystem { get; set; }
        public int StatusValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string DisplayName { get; set; }
    }
}
