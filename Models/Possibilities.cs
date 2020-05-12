using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Possibilities
    {
        public Guid Id { get; set; }
        public Guid StatusId { get; set; }
        public string Fields { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Validate { get; set; }
        public Guid ParentId { get; set; }
        public string StatusName { get; set; }
    }
}
