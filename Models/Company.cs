using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyAddress = new HashSet<CompanyAddress>();
            CompanySku = new HashSet<CompanySku>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int Status { get; set; }
        public int MaxUsers { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string BusinessName { get; set; }
        public string Dotnumber { get; set; }
        public int Type { get; set; }
        public bool? IsTenant { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? InvoiceType { get; set; }
        public string VendorCode { get; set; }
        public string BillingProfile { get; set; }
        public string Email { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddress { get; set; }
        public virtual ICollection<CompanySku> CompanySku { get; set; }
    }
}
