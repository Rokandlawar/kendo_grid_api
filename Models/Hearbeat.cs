using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Hearbeat
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string DataType { get; set; }
        public string CompanyId { get; set; }
        public string AgentUid { get; set; }
        public string AgentVersion { get; set; }
        public string OpenalprVersion { get; set; }
        public string Os { get; set; }
        public string AgentType { get; set; }
        public string SiteId { get; set; }
        public decimal Timestamp { get; set; }
        public decimal SystemUptimeSeconds { get; set; }
        public decimal DaemonUptimeSeconds { get; set; }
        public int CpuCores { get; set; }
        public decimal CpuLastUpdate { get; set; }
        public double CpuUsagePercent { get; set; }
        public int DiskQuotaTotalBytes { get; set; }
        public int DiskQuotaConsumedBytes { get; set; }
        public int DiskQuotaLastUpdate { get; set; }
        public long MemoryConsumedBytes { get; set; }
        public decimal MemoryLastUpdate { get; set; }
        public long MemorySwapusedBytes { get; set; }
        public long MemorySwaptotalBytes { get; set; }
        public long MemoryTotalBytes { get; set; }
        public int ProcessingThreadsActive { get; set; }
        public int ProcessingThreadsConfigured { get; set; }
        public int BeanstalkQueueSize { get; set; }
        public string CameraId { get; set; }
        public int Fps { get; set; }
        public bool IsStreaming { get; set; }
        public string Url { get; set; }
        public decimal LastUpdate { get; set; }
    }
}
