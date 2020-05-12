using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class PlateResults
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string DataType { get; set; }
        public string AgentType { get; set; }
        public decimal? EpochStart { get; set; }
        public decimal? EpochEnd { get; set; }
        public string CameraId { get; set; }
        public string AgentUid { get; set; }
        public string CompanyId { get; set; }
        public string UserData { get; set; }
        public int? FrameStart { get; set; }
        public double? BestConfidence { get; set; }
        public int? Version { get; set; }
        public string BestPlateNumber { get; set; }
        public string BestPlateRegion { get; set; }
        public double? TravelDirection { get; set; }
        public string Country { get; set; }
        public string AgentVersion { get; set; }
        public string BestUuid { get; set; }
        public bool IsParked { get; set; }
        public int? FrameEnd { get; set; }
    }
}
