using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Permissions
    {
        public Guid Id { get; set; }
        public Guid StatusId { get; set; }
        public int RoleId { get; set; }
        public bool Display { get; set; }
        public bool Editable { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Guid GroupId { get; set; }
    }
}
