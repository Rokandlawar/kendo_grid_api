using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class PaymentDetails
    {
        public int? AccountNum { get; set; }
        public int? MessageType { get; set; }
        public string PartnerKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public double FeeAmount { get; set; }
        public string ConfirmationNum { get; set; }
        public string PaymentChannel { get; set; }
        public string PaymentType { get; set; }
        public string AccountDetails { get; set; }
        public int ActivityType { get; set; }
        public int Module { get; set; }
        public Guid Id { get; set; }
    }
}
