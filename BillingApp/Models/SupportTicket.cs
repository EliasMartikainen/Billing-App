using System;
using System.ComponentModel.DataAnnotations;

namespace BillingApp.Models
{
    public class SupportTicket
    {
        [Key]
        public int TicketId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public string Subject { get; set; }

        public string QuestionText { get; set; }

        public string AnswerText { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Pending";

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
