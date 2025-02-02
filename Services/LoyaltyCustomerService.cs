using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Services
{
    internal class LoyaltyCustomerService
    {
        private readonly LoyaltyCustomerRepository _loyaltyCustomerRepo;

        public LoyaltyCustomerService(string connectionString)
        {
            _loyaltyCustomerRepo = new LoyaltyCustomerRepository(connectionString);
        }

        public IEnumerable<LoyaltyCustomer> GetAllLoyaltyCustomers()
        {
            return _loyaltyCustomerRepo.GetAll();
        }

        public LoyaltyCustomer AddLoyaltyCustomer(LoyaltyCustomer customer)
        {
            // Perform any additional business logic here if needed
            _loyaltyCustomerRepo.Insert(customer);
            return customer;
        }

        public void DeleteLoyaltyCustomer(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                throw new ArgumentException("Customer ID is required to delete.");

            _loyaltyCustomerRepo.Delete(customerId);
        }

        public void UpdateBill(int customerCardNumber)
        {
            _loyaltyCustomerRepo.UpdateBill(customerCardNumber);
        }

        public LoyaltyCustomer ValidateAndProcessData(string customerID, string name, string cardNumber, int points, String employeeID)
        {
            if (string.IsNullOrEmpty(customerID))
                throw new ArgumentException("CustomerID is required.");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Customer name is required.");
            if (string.IsNullOrEmpty(cardNumber))
                throw new ArgumentException("Card number is required.");
            if (points < 0)
                throw new ArgumentException("Points must be greater than or equal to 0.");

            return new LoyaltyCustomer
            {
                CustomerID = customerID,
                CustomerName = name,
                CustomerCardNumber = cardNumber,
                Points = points,
                EmployeeID = employeeID
            };
        }

        public IEnumerable<LoyaltyCustomer> SearchLoyaltyCustomers(string searchTerm)
        {
            return _loyaltyCustomerRepo.GetAll().Where(c => c.CustomerID.Contains(searchTerm) || c.CustomerName.Contains(searchTerm) || c.CustomerCardNumber.Contains(searchTerm));
        }
    }
}
