using System;
using Storex;

namespace RepositoryModules
{
    public class FixedLengthSpec
    {
        public static string PropertyKeyForPrimary { get; } = "2026aedc-358d-41c5-a6a3-e03abe5ae5b3";

        public string PrefixKey { get; set; }

        public int ItemNumberStartIndex { get; set; } = 1;

        public int ItemNumberLength { get; set; } = 1;

        public int SerialNumberStartIndex { get; set; } = 1;

        public int SerialNumberLength { get; set; } = 1;

        public bool TryGeneraLabel(Symbol symbol, out ILabel label)
        {
            int minLength;
            minLength = Math.Max(ItemNumberStartIndex + ItemNumberLength - 1, SerialNumberStartIndex + SerialNumberLength - 1);
            minLength = Math.Max(minLength, PrefixKey?.Length ?? 0);

            if (symbol.Value.Length >= minLength & (string.IsNullOrEmpty(PrefixKey) || symbol.Value.StartsWith(PrefixKey)))
            {
                label = new BasicLabel(symbol)
                {
                    ItemNumber = symbol.Value.Substring(ItemNumberStartIndex - 1, ItemNumberLength).TrimEnd(),
                    SerialNumber = symbol.Value.Substring(SerialNumberStartIndex - 1, SerialNumberLength).TrimEnd()
                };
                return true;
            }
            else
            {
                label = null;

                return false;
            }
        }
    }
}