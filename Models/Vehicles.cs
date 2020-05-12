using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Vehicles
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Plate { get; set; }
        public int Year { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int ApplicationId { get; set; }
        public string State { get; set; }
        public string Vin { get; set; }
        public int Pax { get; set; }
        public int CompanyId { get; set; }
        public int Number { get; set; }
        public int Fiscal { get; set; }
        public int PermitType { get; set; }
    }
}
