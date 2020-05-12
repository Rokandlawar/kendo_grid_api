using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Permits
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Month { get; set; }
        public double IssuanceLease { get; set; }
        public double IssuanceNonLease { get; set; }
        public string TermsConditions { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Day { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string ActivityCode { get; set; }
    }
}
