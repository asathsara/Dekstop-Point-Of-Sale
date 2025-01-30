using PointOfSale.Models;
using PointOfSale.Repositories;
using System;

namespace PointOfSale.Services
{
    internal class StoreService
    {
        private readonly StoreRepository _storeRepo;

        public StoreService(string connectionString)
        {
            _storeRepo = new StoreRepository(connectionString);
        }

        public Store GetStore()
        {
            return _storeRepo.GetStore();
        }

        public string ValidateStoreData(Store store)
        {
            if (string.IsNullOrEmpty(store.StoreID))
            {
                return "StoreID is required.";
            }

            if (string.IsNullOrEmpty(store.StoreName))
            {
                return "Store name is required.";
            }

            if (string.IsNullOrEmpty(store.ContactNumber))
            {
                return "Contact number is required.";
            }

            if (string.IsNullOrEmpty(store.Address))
            {
                return "Address is required.";
            }

            return null;  // Validation passed
        }

        public void UpdateStore(Store store)
        {
            _storeRepo.Update(store);
        }

        public Store ValidateAndProcessData(string storeID, string storeName, string contactNumber, string address)
        {
            Store store = new Store
            {
                StoreID = storeID,
                StoreName = storeName,
                ContactNumber = contactNumber,
                Address = address
            };

            // Validate data
            string validationMessage = ValidateStoreData(store);
            if (validationMessage != null)
            {
                throw new Exception(validationMessage);  // Throw exception if validation fails
            }

            return store;
        }
    }
}
