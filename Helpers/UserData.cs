using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Helpers
{
    public static class UserData
    {
        public static int AdminID { get; set; }
        public static string EmployeeID { get; set; } = "E00";

        public readonly static string[] UnitsArray = { "One", "kg", "g", "mg", "l", "ml" };
    }
}
