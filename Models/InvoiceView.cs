using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class InvoiceView
    {
        public DateTime InvoiceDate { get; set; }
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDot { get; set; }
        public int CompanyId { get; set; }
        public Guid? TransactionId { get; set; }
        public string Name { get; set; }
        public string Invoice { get; set; }
        public string ConfirmationNum { get; set; }
        public string BillingProfile { get; set; }
        public string VendorCode { get; set; }
        public int Status { get; set; }
        public int Fiscal { get; set; }
    }
}
