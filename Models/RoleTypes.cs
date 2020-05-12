using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class RoleTypes
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool? IsInternal { get; set; }
        public int RoleId { get; set; }
        public bool? IsSystem { get; set; }
    }
}
