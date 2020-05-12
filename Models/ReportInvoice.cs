using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ReportInvoice
    {
        public long Id { get; set; }
        public int Invoice { get; set; }
        public string Company { get; set; }
        public string Sku { get; set; }
        public int SkuId { get; set; }
        public string FunctionCode { get; set; }
        public string ActivityCode { get; set; }
        public string RevenueCode { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double Amount { get; set; }
        public int Fiscal { get; set; }
        public double? Total { get; set; }
        public int Activity { get; set; }
        public int Type { get; set; }
    }
}
