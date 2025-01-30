namespace PointOfSale.Models
{
    public class LoyaltyCustomer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCardNumber { get; set; }
        public float Points { get; set; }
        public string EmployeeID { get; set; }
    }
}
