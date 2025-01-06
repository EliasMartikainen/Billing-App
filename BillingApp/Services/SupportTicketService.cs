using System;
using System.Collections.Generic;
using System.Linq;
using BillingApp.Models;

namespace BillingApp.Services
{
    public class SupportTicketService
    {
        private static List<SupportTicket> _tickets = new List<SupportTicket>();
        private static int _ticketIdCounter = 1;

        public SupportTicket CreateTicket(int customerId, int serviceId, string subject, string questionText)
        {
            var ticket = new SupportTicket
            {
                TicketId = _ticketIdCounter++,
                CustomerId = customerId,
                ServiceId = serviceId,
                Subject = subject,
                QuestionText = questionText,
                Status = "Pending",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };

            _tickets.Add(ticket);
            return ticket;
        }

        public SupportTicket GetTicketById(int ticketId)
        {
            return _tickets.FirstOrDefault(t => t.TicketId == ticketId);
        }

        public List<SupportTicket> GetTicketsByCustomer(int customerId)
        {
            return _tickets.Where(t => t.CustomerId == customerId).ToList();
        }

        public List<SupportTicket> GetTicketsByService(int serviceId)
        {
            return _tickets.Where(t => t.ServiceId == serviceId).ToList();
        }

        public bool UpdateTicketStatus(int ticketId, string newStatus)
        {
            var ticket = GetTicketById(ticketId);
            if (ticket == null) return false;

            ticket.Status = newStatus;
            ticket.UpdatedDate = DateTime.UtcNow;
            return true;
        }

        public bool AnswerTicket(int ticketId, string answer)
        {
            var ticket = GetTicketById(ticketId);
            if (ticket == null) return false;

            ticket.AnswerText = answer;
            ticket.Status = "New Response"; // or "Resolved"
            ticket.UpdatedDate = DateTime.UtcNow;
            return true;
        }

        public List<SupportTicket> GetAllTickets()
        {
            return _tickets;
        }
    }
}
