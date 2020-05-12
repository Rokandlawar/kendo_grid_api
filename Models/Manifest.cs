using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Manifest
    {
        public Guid Id { get; set; }
        public int InvoiceId { get; set; }
        public int SkuId { get; set; }
        public string SkuName { get; set; }
        public double Amount { get; set; }
        public bool? AllowEdit { get; set; }
    }
}
