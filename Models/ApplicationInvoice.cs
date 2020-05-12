using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ApplicationInvoice
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int Count { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Guid TransactionId { get; set; }
    }
}
