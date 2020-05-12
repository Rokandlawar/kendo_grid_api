using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class EventStatement
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string CameraId { get; set; }
        public string Location { get; set; }
        public string Activity { get; set; }
        public int SkuType { get; set; }
        public int SkuId { get; set; }
        public double Charge { get; set; }
        public Guid? ImageId { get; set; }
        public int Status { get; set; }
        public string PlateNumber { get; set; }
        public string PlateRegion { get; set; }
        public int? CompanyId { get; set; }
        public DateTime ActivityTime { get; set; }
        public string ImageUid { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool? IsFirst { get; set; }
        public string CompanyDot { get; set; }
        public int VehicleType { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? IsPaid { get; set; }
        public int Sku { get; set; }
    }
}
