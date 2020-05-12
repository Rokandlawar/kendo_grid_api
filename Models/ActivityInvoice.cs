using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ActivityInvoice
    {
        public string RevenueCode { get; set; }
        public string FunctionCode { get; set; }
        public string ActivityCode { get; set; }
        public double Total { get; set; }
        public string Name { get; set; }
        public int InvoiceId { get; set; }
    }
}
