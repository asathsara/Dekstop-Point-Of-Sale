using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Supplier
    {
        public string SupplierID { get; set; }
        public string ItemName { get; set; }
        public string SupplierName { get; set; }
        public int ContactNumber { get; set; }
        public int WholeSaleQuantity { get; set; }
        public int WholeSaleUnit { get; set; }
        public float WholeSaleUnitPrice { get; set; }
        public string AdminID { get; set; }
    }
}
