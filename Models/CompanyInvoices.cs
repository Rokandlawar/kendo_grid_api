using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class CompanyInvoices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InvoiceId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Status { get; set; }
        public int CompanyId { get; set; }
    }
}
