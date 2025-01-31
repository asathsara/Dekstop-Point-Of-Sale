using PointOfSale.Helpers;
using PointOfSale.Models;

namespace PointOfSale
{
    public static class ProfitCalculator
    {
        public static float CalculateProfit(ItemData cachedItemData)
        {
            // Wholesale data
            float wholesaleQuantity = cachedItemData.WholeSaleQuantity; // 10
            string wholesaleUnit = UserData.UnitsArray[cachedItemData.WholeSaleUnit]; // kg
            float wholesalePrice = cachedItemData.WholeSaleUnitPrice; // 10000

            // Retail data
            float retailQuantity = cachedItemData.RetailQuantity; // 100
            string retailUnit = UserData.UnitsArray[cachedItemData.RetailUnit]; // g
            float retailPrice = cachedItemData.RetailUnitPrice; // 200

            // Convert wholesale and retail quantities to base units 
            float wholesaleBaseQuantity = UnitConverter.ConvertToBaseUnit(wholesaleQuantity, wholesaleUnit); // 10  * 1000 = 10000
            float retailBaseQuantity = UnitConverter.ConvertToBaseUnit(retailQuantity, retailUnit); // 100 * 1 = 100

            // Calculate the cost per base unit for wholesale
            // 10000 / 10000 = 1
            float wholesaleCostPerUnit = wholesalePrice / wholesaleBaseQuantity;

            // Calculate the revenue per base unit for retail
            // 200 / 100 = 2
            float retailRevenuePerUnit = retailPrice / retailBaseQuantity;


            // Profit per base unit (revenue - cost)
            // 2 - 1 = 1
            float profitPerUnit = retailRevenuePerUnit - wholesaleCostPerUnit;

            // Calculate total profit for the retail quantity
            // 1 * 100 = 100
            float totalProfit = profitPerUnit * retailBaseQuantity;

            // 100
            return totalProfit;
        }
    }

}
