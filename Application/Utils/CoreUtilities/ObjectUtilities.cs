using Newtonsoft.Json;

namespace Utils.CoreUtilities
{
    public static class ObjectUtilities
    {
        /// <summary>
        /// Check object is null or not
        /// </summary>
        /// <param name="input">String</param>
        /// <returns></returns>
        public static bool IsNull(this object input)
        {
            return input == null ? true : false;
        }

        /// <summary>
        /// Check object is null or not
        /// </summary>
        /// <param name="input">Object</param>
        /// <returns></returns>
        public static bool IsNotNull(this object input)
        {
            return !IsNull(input);
        }

        /// <summary>
        /// Convert any type into string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ConvertToString(this object input)
        {
            if (input.IsNotNull())
            {
                return input.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Convert any type into string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ConvertToLower(this object input)
        {
            if (input.IsNotNull())
            {
                return input.ToString().ToLower().Trim();
            }
            return string.Empty;
        }

        /// <summary>
        /// Deserialize string into T type
        /// </summary>
        /// <typeparam name="T"> Generic object</typeparam>
        /// <param name="input">JSON in string format</param>
        /// <returns></returns>
        public static T DeserializeString<T>(this string input)
        {
            if (input.IsEmpty())
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(input);
        }
    }
}
