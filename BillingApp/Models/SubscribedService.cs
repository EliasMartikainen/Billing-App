using System;
using System.ComponentModel.DataAnnotations;

namespace BillingApp.Models
{
    public class SubscribedService
    {
        [Key]
        public int SubscribedServiceId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
