using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ActivityNevents
    {
        public string ActivityCode { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string Name { get; set; }
        public int InvoiceId { get; set; }
        public double? Charge { get; set; }
        public int? PaidInvoice { get; set; }
        public int CameraEvent { get; set; }
        public string Plate { get; set; }
        public string Region { get; set; }
        public DateTime? BilledDate { get; set; }
    }
}
