using System;
using System.Collections.Generic;
using System.Linq;
using BillingApp.Models;

namespace BillingApp.Services
{
    public class InvoiceService
    {
        private static List<Invoice> _invoices = new List<Invoice>();
        private static int _invoiceIdCounter = 1;

        public Invoice CreateInvoice(int customerId, int serviceId, decimal price)
        {
            var invoice = new Invoice
            {
                InvoiceId = _invoiceIdCounter++,
                CustomerId = customerId,
                ServiceId = serviceId,
                InvoiceDate = DateTime.Now,
                Price = price,
                IsPaid = false
            };
            _invoices.Add(invoice);
            return invoice;
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return _invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);
        }

        public List<Invoice> GetInvoicesForCustomer(int customerId)
        {
            return _invoices.Where(i => i.CustomerId == customerId).ToList();
        }

        public bool MarkPaid(int invoiceId)
        {
            var invoice = GetInvoiceById(invoiceId);
            if (invoice == null) return false;
            invoice.IsPaid = true;
            return true;
        }

        public List<Invoice> GetAllInvoices()
        {
            return _invoices;
        }
    }
}
