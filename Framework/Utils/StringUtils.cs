using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace NUnitSpecFlow.Framework.Utils
{
    internal class StringUtils
    {
        private const string CurrencyRegex = "[^\\d.]";

        public static double GetDoubleFromString(string value)
        {
            string cleanedValue = Regex.Replace(value, CurrencyRegex, "");

            return double.Parse(cleanedValue, CultureInfo.InvariantCulture);
        }
    }
}
