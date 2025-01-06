using System;
using System.Collections.Generic;
using System.Linq;
using BillingApp.Models;
using BillingApp.Data;

namespace BillingApp.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public Customer CreateCustomer(string name, string billingInfo, string subscribedServices,
            string subscriptionStartDateString, string subscriptionEndDateString = "", string isPaid = "No")
        {
            try
            {
                // make subscriptionstartdate and enddatetime to DateTime
                DateTime subscriptionStartDate = DateTime.Parse(subscriptionStartDateString);
                DateTime subscriptionEndDate = DateTime.Parse(subscriptionEndDateString);

                // Generate a new unique customer ID
                int newCustomerId;
                do
                {
                    newCustomerId = (_context.Customers.Max(c => (int?)c.CustomerId) ?? 0) + 1;
                } while (_context.Customers.Any(c => c.CustomerId == newCustomerId));

                var newCustomer = new Customer
                {
                    CustomerId = newCustomerId,
                    CustomerName = name,
                    BillingInfo = billingInfo,
                    SubscribedServices = subscribedServices,
                    SubscriptionStartDate = subscriptionStartDate,
                    SubscriptionEndDate = subscriptionEndDate,
                    IsPaid = isPaid,
                    UserId = newCustomerId
                };

                _context.Customers.Add(newCustomer);
                _context.SaveChanges();
                return newCustomer;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new Exception("An error occurred while creating the customer.", ex);
            }
        }

        public List<Service> GetServices()
        {
            return _context.Services.ToList();
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == customerId);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new Exception("An error occurred while deleting the customer.", ex);
            }
        }
    }
}
