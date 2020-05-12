using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Receipt
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int PaymentType { get; set; }
        public string ConfirmationNum { get; set; }
        public Guid EntityId { get; set; }
    }
}
