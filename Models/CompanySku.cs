using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class CompanySku
    {
        public Guid Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SkuId { get; set; }
        public double Value { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public double? Multiplier { get; set; }
        public bool IsEdit { get; set; }
        public int Type { get; set; }
        public int InvoiceId { get; set; }
        public bool AllowEvents { get; set; }

        public virtual Company Company { get; set; }
    }
}
