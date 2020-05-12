using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class RenewPermits
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int PermitId { get; set; }
    }
}
