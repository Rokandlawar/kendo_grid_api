using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Notices
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Module { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Template { get; set; }
        public bool AllowEdit { get; set; }
        public bool? AllowPast { get; set; }
        public bool? AllowCurrent { get; set; }
        public bool? AllowFuture { get; set; }
    }
}
