namespace Kaz.Operations.Core
{
    /// <summary>
    /// Specifies the calculation logic used for percentage-based operations.
    /// </summary>
    public enum PercentageCalculationMethod
    {
        /// <summary>
        /// Calculates the value that represents a specified percentage of a total.
        /// </summary>
        FractionOfTotal,
        /// <summary>
        /// Calculates the ratio between a specific value and a total as a percentage.
        /// </summary>
        RatioOfTotal
    }

    /// <summary>
    /// Specifies the criteria for identifying and extracting numeric sequences from a string.
    /// </summary>
    public enum NumberExtractionOptions
    {
        /// <summary>
        /// Matches sequences consisting only of decimal digits.
        /// </summary>
        Digits,

        /// <summary>
        /// Matches numeric sequences including optional signs and decimal points.
        /// </summary>
        Decimals,

        /// <summary>
        /// Matches numeric sequences in scientific notation, including signs, decimal points, and exponents.
        /// </summary>
        Scientific
    }
}
