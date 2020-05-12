using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Users
    {
        public Users()
        {
            UserLoginHistory = new HashSet<UserLoginHistory>();
            UserPasswordRecovery = new HashSet<UserPasswordRecovery>();
            UserPasswords = new HashSet<UserPasswords>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? CompanyId { get; set; }
        public bool? IsActive { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Fax { get; set; }
        public Guid RoleId { get; set; }

        public virtual ICollection<UserLoginHistory> UserLoginHistory { get; set; }
        public virtual ICollection<UserPasswordRecovery> UserPasswordRecovery { get; set; }
        public virtual ICollection<UserPasswords> UserPasswords { get; set; }
    }
}
