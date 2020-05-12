using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class UserLoginHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Ip { get; set; }
        public DateTime LoginDate { get; set; }
        public byte IsSuccess { get; set; }

        public virtual Users User { get; set; }
    }
}
