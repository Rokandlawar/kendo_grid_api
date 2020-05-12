using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class NotificationLog
    {
        public int Id { get; set; }
        public int Module { get; set; }
        public int Type { get; set; }
        public int? Entity { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Company { get; set; }
    }
}
