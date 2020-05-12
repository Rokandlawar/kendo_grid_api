using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Charges
    {
        public Guid Id { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string ActivityCode { get; set; }
        public double Amount { get; set; }
        public Guid InvoiceId { get; set; }
        public int EntityId { get; set; }
        public int Module { get; set; }
        public int FiscalYear { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ChargeDescription { get; set; }
        public bool? Reversed { get; set; }
    }
}
