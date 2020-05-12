using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Files
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int EntityId { get; set; }
        public string ContentType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Extension { get; set; }
        public string Location { get; set; }
    }
}
