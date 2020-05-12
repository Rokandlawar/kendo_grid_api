using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Notifications
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Module { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Template1 { get; set; }
        public string Recepients { get; set; }
        public int EventOn { get; set; }
        public string EventDetails { get; set; }
        public string Template2 { get; set; }
        public bool AllowExternal { get; set; }
        public string Subject { get; set; }
        public int? FrequencyType { get; set; }
        public int? Frequency { get; set; }
        public int? FrequencyDate { get; set; }
        public int? FrequencyMonth { get; set; }
    }
}
