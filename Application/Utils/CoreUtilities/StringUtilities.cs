using System;

namespace Utils.CoreUtilities
{
    public static class StringUtilities
    {
        /// <summary>
        /// Check string is null or empty (Blankspace)
        /// </summary>
        /// <param name="input">String</param>
        /// <returns></returns>
        public static bool IsEmpty(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Check string is null or empty (Blankspace)
        /// </summary>
        /// <param name="input">String</param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string input)
        {
            return !IsEmpty(input);
        }


        /// <summary>
        /// Compare input string with comapared string, 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="compareTo"></param>
        /// <returns>Bool</returns>
        public static bool StringComapre(this string input, string compareTo)
        {
            return input.ToLower().Trim() == compareTo.ToLower().Trim();
        }

        /// <summary>
        /// Get AppSetting value by key, if not founf then send empty value
        /// </summary>
        /// <param name="key">App key </param>
        /// <returns>App value as string</returns>
        public static string GetAppSetting(string key)
        {
            //if (ConfigurationManager.AppSettings[key].IsNull())
            //{
            //    return string.Empty;
            //}
            //else
            //{
            //    return ConfigurationManager.AppSettings[key].ToString().Trim();
            //}

            return string.Empty;
        }


        /// <summary>
        /// Get string value, if null then empty string 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetValue(this string input)
        {
            return input ?? string.Empty;
        }

        public static string ConvertToLower(this string input)
        {
            return GetValue(input).ToString().ToLower().Trim();
        }

        /// <summary>
        /// Compare input string with comapared string, 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="compareTo"></param>
        /// <returns>Bool</returns>
        public static bool StringComapre(this string input, object compareTo)
        {
            var comapre = string.Empty;
            if (compareTo.IsNotNull())
            {
                comapre = compareTo.ConvertToLower();
            }

            return input.ToLower().Trim() == comapre;
        }
    }
}
