using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Skus
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string FunctionCode { get; set; }
        public string RevenueCode { get; set; }
        public string ActivityCode { get; set; }
        public int TriggerType { get; set; }
        public string CameraId { get; set; }
        public int? PermitId { get; set; }
        public int? NonPermitId { get; set; }
        public int? PermitType { get; set; }
        public double? PermitAmount1 { get; set; }
        public double? PermitAmount2 { get; set; }
        public int? NonPermitType { get; set; }
        public double? NonPermitAmount1 { get; set; }
        public double? NonPermitAmount2 { get; set; }
        public bool? AllowPermitted { get; set; }
        public bool? AllowNonPermitted { get; set; }
        public bool? UserCanEdit { get; set; }
        public int? UserInputType { get; set; }
        public string UserInputValue { get; set; }
        public string FixedAmount { get; set; }
        public int? PermitTime { get; set; }
        public int? NonPermitTime { get; set; }
    }
}
