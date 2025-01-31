using System;
using System.Collections.Generic;

namespace PointOfSale.Models
{
    public class BillData
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public List<TableItem> TableItems { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public float Total { get; set; }
        public float AmountPaid { get; set; }
        public float Balance { get; set; }
        public int CustomerCardNumber { get; set; }
        public int CustomerPoints { get; set; }
        public string EmployeeName { get; set; }
    }

}
