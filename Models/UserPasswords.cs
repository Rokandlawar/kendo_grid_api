using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class UserPasswords
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public byte? IsActive { get; set; }

        public virtual Users User { get; set; }
    }
}
