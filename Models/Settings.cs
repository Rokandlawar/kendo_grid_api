using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Settings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Setting { get; set; }
        public string Template { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? Module { get; set; }
    }
}
