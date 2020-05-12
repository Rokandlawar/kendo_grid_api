using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class NoticeTemplates
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int Module { get; set; }
        public string Template { get; set; }
        public Guid Attachment { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int NoticeId { get; set; }
    }
}
