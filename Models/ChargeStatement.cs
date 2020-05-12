using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class ChargeStatement
    {
        public Guid Id { get; set; }
        public int Module { get; set; }
        public int EntityId { get; set; }
        public double Charge { get; set; }
        public bool? IsPaid { get; set; }
        public Guid InvoiceId { get; set; }
        public int SkuId { get; set; }
        public int ItemType { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string ActivityCode { get; set; }
        public string Name { get; set; }
    }
}
