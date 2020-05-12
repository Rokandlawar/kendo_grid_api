using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class RoadNetworks
    {
        public double Fakeid { get; set; }
        public double? Objectid { get; set; }
        public double? RdwayId { get; set; }
        public double? RdType { get; set; }
        public string RoadNo { get; set; }
        public double? RoadNum { get; set; }
        public double? CountyCode { get; set; }
        public string DirFlag { get; set; }
        public string Ispublish { get; set; }
        public double? BegMp { get; set; }
        public double? EndMp { get; set; }
        public double? RbegMp { get; set; }
        public double? RendMp { get; set; }
        public double? SegmentLength { get; set; }
        public double? MileLength { get; set; }
        public double? RmileLength { get; set; }
        public double? Percentdiff { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createdby { get; set; }
        public DateTime? Updatedate { get; set; }
        public string Updatedby { get; set; }
        public string Comments { get; set; }
        public double? Id { get; set; }
        public string Name { get; set; }
        public string Needreinventory { get; set; }
        public string Needrebounday { get; set; }
        public string Networktype { get; set; }
        public string Isfeeder { get; set; }
        public string Isdart { get; set; }
        public string Isschool { get; set; }
        public string Subdevid { get; set; }
    }
}
