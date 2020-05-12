using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class CompanyAddress
    {
        public Guid Id { get; set; }
        public int CompanyId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? Type { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? Status { get; set; }

        public virtual Company Company { get; set; }
    }
}
