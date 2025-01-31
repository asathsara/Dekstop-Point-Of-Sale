namespace PointOfSale.Models
{
    public class ItemData
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int Barcode { get; set; }
        public int RetailQuantity { get; set; }
        public int RetailUnit { get; set; }
        public float RetailUnitPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string AdminID { get; set; }
        public string SupplierID { get; set; }
        public int WholeSaleQuantity { get; set; }
        public int WholeSaleUnit { get; set; }
        public float WholeSaleUnitPrice { get; set; }
    }
}
