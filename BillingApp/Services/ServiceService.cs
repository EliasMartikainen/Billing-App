using System.Collections.Generic;
using System.Linq;
using BillingApp.Models;

namespace BillingApp.Services
{
    public class ServiceService
    {
        private static List<Service> _services = new List<Service>();
        private static int _serviceIdCounter = 1;

        public Service CreateService(string serviceName, decimal price, string supportPackageDetails)
        {
            var newService = new Service
            {
                ServiceId = _serviceIdCounter++,
                ServiceName = serviceName,
                Price = price,
                SupportPackageDetails = supportPackageDetails
            };

            _services.Add(newService);
            return newService;
        }

        public Service GetServiceById(int serviceId)
        {
            return _services.FirstOrDefault(s => s.ServiceId == serviceId);
        }

        public List<Service> GetAllServices()
        {
            return _services;
        }

        public bool UpdateService(Service updated)
        {
            var existing = GetServiceById(updated.ServiceId);
            if (existing == null) return false;

            existing.ServiceName = updated.ServiceName;
            existing.Price = updated.Price;
            existing.SupportPackageDetails = updated.SupportPackageDetails;
            return true;
        }

        public bool DeleteService(int serviceId)
        {
            var existing = GetServiceById(serviceId);
            if (existing == null) return false;

            _services.Remove(existing);
            return true;
        }
    }
}
