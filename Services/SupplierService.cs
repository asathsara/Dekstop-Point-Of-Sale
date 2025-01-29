using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;

namespace PointOfSale.Services
{
    public class SupplierService
    {
        private readonly SupplierRepository _supplierRepo;

        public SupplierService(string connectionString)
        {
            _supplierRepo = new SupplierRepository(connectionString);
        }

        public void AddSupplier(Supplier supplier)
        {
            // Validation logic moved here
            if (string.IsNullOrEmpty(supplier.SupplierID))
                throw new ArgumentException("Supplier ID is required.");
            if (string.IsNullOrEmpty(supplier.SupplierName))
                throw new ArgumentException("Supplier Name is required.");
            if (string.IsNullOrEmpty(supplier.ItemName))
                throw new ArgumentException("Item Name is required.");
            if (supplier.ContactNumber <= 0)
                throw new ArgumentException("Invalid Contact Number.");
            if (supplier.WholeSaleQuantity <= 0)
                throw new ArgumentException("Invalid Quantity.");
            if (supplier.WholeSaleUnit < 0)
                throw new ArgumentException("Invalid Unit.");
            if (supplier.WholeSaleUnitPrice <= 0)
                throw new ArgumentException("Invalid Unit Price.");

            // Pass valid Supplier object to repository
            _supplierRepo.Insert(supplier);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepo.GetAll();
        }

        public void DeleteSupplier(string supplierId)
        {
            if (string.IsNullOrEmpty(supplierId))
                throw new ArgumentException("Supplier ID is required to delete.");

            _supplierRepo.Delete(supplierId);
        }
    }
}
