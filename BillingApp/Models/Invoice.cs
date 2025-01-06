using System;
using System.ComponentModel.DataAnnotations;

namespace BillingApp.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal Price { get; set; }

        public bool IsPaid { get; set; }
    }
}
