using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class InvoiceCycles
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Frequency { get; set; }
        public int FrequencyType { get; set; }
        public int FrequencyDate { get; set; }
        public int FrequencyMonth { get; set; }
        public int TemplateDue { get; set; }
        public int PaymentDue { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsRenewal { get; set; }
        public bool AllowEvents { get; set; }
    }
}
