using System;

namespace PointOfSale.Models
{
    public class Bill
    {

        public float Total { get; set; }
        public float TotalProfit { get; set; }
        public float DiscountPercentage { get; set; }
        public float CustomerPoints { get; set; }
        public float TotalDiscount { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string EmployeeID { get; set; }
        public string CustomerCardNumber { get; set; }
        public string StoreID { get; set; }
    }
}
