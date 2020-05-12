using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class SystemSettings
    {
        public int Id { get; set; }
        public int InvoiceCycle { get; set; }
        public int Frequency { get; set; }
        public int FrequencyType { get; set; }
        public int FrequencyDate { get; set; }
        public int FrequencyMonth { get; set; }
        public string FileName { get; set; }
        public bool AppendDate { get; set; }
        public bool AllowEmail { get; set; }
        public string EmailList { get; set; }
        public bool AllowFtp { get; set; }
    }
}
