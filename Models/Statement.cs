using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Statement
    {
        public Statement()
        {
            Itemization = new HashSet<Itemization>();
        }

        public Guid Id { get; set; }
        public int? CompanyId { get; set; }
        public int FiscalYear { get; set; }
        public string InvoiceNumber { get; set; }
        public int InvoiceStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public DateTime FinalizeDue { get; set; }
        public DateTime? DueDate { get; set; }
        public string Remarks { get; set; }
        public bool? Temporary { get; set; }
        public int? InvoiceCycle { get; set; }

        public virtual ICollection<Itemization> Itemization { get; set; }
    }
}
