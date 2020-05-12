using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ModuleGroups
    {
        public Guid Id { get; set; }
        public int Module { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
