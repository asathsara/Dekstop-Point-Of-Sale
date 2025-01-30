namespace PointOfSale.Helpers
{
    public static class UserData
    {
        public static int AdminID { get; set; }
        public static string EmployeeID { get; set; } = "E00";

        public readonly static string[] UnitsArray = { "One", "kg", "g", "mg", "l", "ml" };
    }
}
