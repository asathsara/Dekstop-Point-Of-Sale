namespace PointOfSale.Models
{
    public class TableItem
    {
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float ItemAmount { get; set; }
        public float ItemProfit { get; set; }
    }
}
