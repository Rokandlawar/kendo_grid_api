using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class InvoiceStatement
    {
        public Guid Id { get; set; }
        public int? CompanyId { get; set; }
        public int FiscalYear { get; set; }
        public string InvoiceNumber { get; set; }
        public int InvoiceStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public DateTime FinalizeDue { get; set; }
        public DateTime? DueDate { get; set; }
        public string Remarks { get; set; }
        public bool? Temporary { get; set; }
        public int? InvoiceCycle { get; set; }
        public double? AmountPaid { get; set; }
        public double? AmountDue { get; set; }
    }
}
