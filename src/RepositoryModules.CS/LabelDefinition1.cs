using System;
using Newtonsoft.Json;
using Storex;

namespace RepositoryModules
{
    public class LabelDefinition1
    {
        public static string KeyForPrimary { get; private set; } = "2026aedc-358d-41c5-a6a3-e03abe5ae5b3";

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

        public static bool TryExtract(IMode mode, string name, out LabelDefinition1 definition)
        {
            if (mode.ExtendedProperties.TryGetValue(name, out var objValue) && objValue is LabelDefinition1 value)
            {
                definition = value;

                return true;
            }
            else if (objValue != null)
            {
                try
                {
                    definition = JsonConvert.DeserializeObject<LabelDefinition1>(JsonConvert.SerializeObject(objValue));

                    return true;
                }
                catch (JsonException)
                {
                    definition = null;

                    return false;
                }
            }
            else
            {
                definition = null;

                return false;
            }
        }
    }
}