using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class PermitData
    {
        public int Id { get; set; }
        public int? Status { get; set; }
        public int? CompanyId { get; set; }
        public bool? IsSatisfied { get; set; }
        public DateTime? Glexpiration { get; set; }
        public DateTime? Alexpiration { get; set; }
        public DateTime? Wcexpiration { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDot { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? RiskSent { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? MailDate { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
        public bool IsRenewal { get; set; }
        public DateTime? RenewalDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Name { get; set; }
        public int VehicleId { get; set; }
        public int PermitId { get; set; }
        public DateTime? RiskReceived { get; set; }
        public int Fiscal { get; set; }
        public int PermitNumber { get; set; }
    }
}
