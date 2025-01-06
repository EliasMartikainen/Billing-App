using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingApp.Models
{
    public class Customer
    {
        public Customer() { }

        public Customer(int customerId, string customerName, string billingInfo, int? userId, User user, string subscribedServices)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            BillingInfo = billingInfo;
            UserId = userId;
            SubscribedServices = subscribedServices;
        }

        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [Required]
        public string BillingInfo { get; set; }

        [Required]
        public int? UserId { get; set; }

        [Required]
        public string SubscribedServices { get; set; }

        [Required]
        public DateTime SubscriptionStartDate { get; set; }

        public DateTime? SubscriptionEndDate { get; set; }

        [Required]
        public string IsPaid { get; set; }
    }
}
