using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class EventInvoice
    {
        public int InvoiceId { get; set; }
        public double? Charge { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string ActivityCode { get; set; }
        public string Name { get; set; }
        public int? PaidInvoice { get; set; }
        public string PlateNumber { get; set; }
        public string PlateRegion { get; set; }
        public DateTime? ActivityTime { get; set; }
    }
}
