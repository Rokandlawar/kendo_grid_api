using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Invoices
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int Status { get; set; }
        public int CompanyId { get; set; }
        public Guid? TransactionId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public DateTime FinalizeDue { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDot { get; set; }
        public int Cycle { get; set; }
        public string Remarks { get; set; }
        public int Fiscal { get; set; }
    }
}
