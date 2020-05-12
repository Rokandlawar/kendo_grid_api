using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Cameras
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string CameraId { get; set; }
        public string CameraIp { get; set; }
        public string CameraUrl { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Guid CameraKey { get; set; }
        public int? CameraPort { get; set; }
    }
}
