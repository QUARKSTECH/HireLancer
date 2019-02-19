using Newtonsoft.Json;
using System.Collections.Generic;

namespace Utils.CoreUtilities
{
    public static class DictionaryUtilities
    {

        /// <summary>
        /// Serialize dictionary into string
        /// </summary>
        /// <param name="extraProps">Dictionary</param>
        /// <returns>Serialized string</returns>
        public static string SerializeDictionary(this IDictionary<string, object> extraProps)
        {
            if (extraProps != null)
            {
                return JsonConvert.SerializeObject(extraProps);
            }
            return null;
        }

        /// <summary>
        /// Deserialized string into dictionary
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>Dictionary</returns>
        public static Dictionary<string, object> DeserializeDictionary(this string input)
        {
            if (!input.IsEmpty())
            {
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(input);
            }
            return new Dictionary<string, object>();
        }

    }
}
