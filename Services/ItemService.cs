using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;

namespace PointOfSale.Services
{
    public class ItemService
    {
        private readonly ItemRepository _itemRepo;

        public ItemService(string connectionString)
        {
            _itemRepo = new ItemRepository(connectionString);
        }

        public void AddItem(Item item)
        {
            // Validation logic moved here
            if (string.IsNullOrEmpty(item.ItemID))
                throw new ArgumentException("Item ID is required.");
            if (string.IsNullOrEmpty(item.ItemName))
                throw new ArgumentException("Item Name is required.");
            if (item.Barcode <= 0)
                throw new ArgumentException("Invalid Barcode.");
            if (item.RetailQuantity <= 0)
                throw new ArgumentException("Invalid Quantity.");
            if (item.RetailUnit < 0)
                throw new ArgumentException("Invalid Unit.");
            if (item.RetailUnitPrice <= 0)
                throw new ArgumentException("Invalid Unit Price.");
            if (item.Stock < 0)
                throw new ArgumentException("Invalid Stock.");
            if (string.IsNullOrEmpty(item.SupplierID))
                throw new ArgumentException("Supplier is required.");

            // Pass valid Item object to repository
            _itemRepo.Insert(item);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemRepo.GetAll();
        }

        public void DeleteItem(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
                throw new ArgumentException("Item ID is required to delete.");

            _itemRepo.Delete(itemId);
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _itemRepo.GetSuppliers();
        }

        public List<string> GetItemsBySupplier(string supplierID)
        {
            return _itemRepo.GetItems(supplierID);
        }
    }
}
