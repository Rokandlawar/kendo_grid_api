using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Itemization
    {
        public Guid Id { get; set; }
        public int EntityId { get; set; }
        public int Module { get; set; }
        public Guid InvoiceId { get; set; }

        public virtual Statement Invoice { get; set; }
    }
}
