using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Topics
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Template { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Order { get; set; }
    }
}
