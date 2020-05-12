using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Companymanifest
    {
        public int Id { get; set; }
        public bool IsFixed { get; set; }
        public double Multiplier { get; set; }
        public double Amount { get; set; }
        public bool AllowEdit { get; set; }
        public Guid InvoiceId { get; set; }
        public int SkuId { get; set; }
    }
}
