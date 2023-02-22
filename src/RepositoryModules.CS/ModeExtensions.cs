using Newtonsoft.Json;
using Storex;

namespace RepositoryModules
{
    public static class ModeExtensions
    {
        public static bool TryExtractProperty<T>(this IMode mode, string key, out T value) where T : class
        {
            if (mode.ExtendedProperties.TryGetValue(key, out var objValue) && objValue is T v)
            {
                value = v;

                return true;
            }
            else if (objValue != null)
            {
                try
                {
                    value = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(objValue));

                    return true;
                }
                catch (JsonException)
                {
                    value = null;

                    return false;
                }
            }
            else
            {
                value = null;

                return false;
            }
        }
    }
}