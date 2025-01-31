namespace PointOfSale.Models
{
    public class BillItem
    {

        public float Total { get; set; }
        public string ItemName { get; set; }
        public int CustomerQuantity { get; set; }
        public float ItemProfit { get; set; }
        public float UnitPrice { get; set; }
        public int CustomerUnit { get; set; }
        public string BillID { get; set; }
        public string ItemID { get; set; }
    }
}
