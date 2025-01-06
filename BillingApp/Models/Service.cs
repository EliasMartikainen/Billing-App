using System.ComponentModel.DataAnnotations;

namespace BillingApp.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ServiceName { get; set; }

        public decimal Price { get; set; }

        public string SupportPackageDetails { get; set; }
    }
}
