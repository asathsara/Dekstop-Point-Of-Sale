using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepo;

        public EmployeeService(string connectionString)
        {
            _employeeRepo = new EmployeeRepository(connectionString);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public Employee AddEmployee(Employee employee)
        {
            // Perform any additional business logic here if needed (e.g., password hashing, etc.)
            _employeeRepo.Insert(employee);
            return employee;
        }

        public void DeleteEmployee(string employeeId)
        {
            if (string.IsNullOrEmpty(employeeId))
                throw new ArgumentException("Employee ID is required to delete.");

            _employeeRepo.Delete(employeeId);
        }

        public Employee ValidateAndProcessData(string employeeID, string username, string password, string name)
        {
            if (string.IsNullOrEmpty(employeeID))
                throw new ArgumentException("EmployeeID is required.");
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Username is required.");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password is required.");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Employee name is required.");

            return new Employee
            {
                EmployeeID = employeeID,
                Username = username,
                Password = password,
                EmployeeName = name,
                AdminID = UserData.AdminID.ToString()
            };
        }

        public IEnumerable<Employee> SearchEmployees(string searchTerm)
        {
            return _employeeRepo.GetAll().Where(e => e.EmployeeID.Contains(searchTerm) || e.Username.Contains(searchTerm) || e.EmployeeName.Contains(searchTerm));
        }
    }
}
