namespace PointOfSale
{
    public static class UnitConverter
    {
        // Conversion rates for mass units (relative to grams)
        private static readonly Dictionary<string, float> MassConversionRates = new Dictionary<string, float>
    {
        { "kg", 1000.0f },
        { "g", 1.0f },
        { "mg", 0.001f }
    };

        // Conversion rates for volume units (relative to milliliters)
        private static readonly Dictionary<string, float> VolumeConversionRates = new Dictionary<string, float>
    {
        { "l", 1000.0f },
        { "ml", 1.0f }
    };

        public static bool AreUnitsCompatible(string unit1, string unit2)
        {
            return (MassConversionRates.ContainsKey(unit1) && MassConversionRates.ContainsKey(unit2)) ||
                   (VolumeConversionRates.ContainsKey(unit1) && VolumeConversionRates.ContainsKey(unit2)) || unit1 == unit2;
        }

        public static float ConvertToBaseUnit(float quantity, string unit)
        {
            if (MassConversionRates.ContainsKey(unit))
            {
                return quantity * MassConversionRates[unit];
            }
            if (VolumeConversionRates.ContainsKey(unit))
            {
                return quantity * VolumeConversionRates[unit];
            }
            if (unit == "One")
            {
                return quantity;
            }
            throw new ArgumentException($"Unsupported or incompatible unit: {unit}");
        }
    }


}
