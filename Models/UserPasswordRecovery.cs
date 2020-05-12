using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class UserPasswordRecovery
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public byte? IsUsed { get; set; }

        public virtual Users User { get; set; }
    }
}
