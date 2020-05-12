using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ActivityInvoice1
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public double? Multiplier { get; set; }
        public double? Amount { get; set; }
        public double Total { get; set; }
        public int CompanyId { get; set; }
        public int InvoiceId { get; set; }
        public Guid? TransactionId { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Name { get; set; }
        public bool IsEdit { get; set; }
        public Guid SkuId { get; set; }
    }
}
