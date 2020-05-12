using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Notes
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Module { get; set; }
        public int EntityId { get; set; }
    }
}
