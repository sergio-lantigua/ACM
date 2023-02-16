using System.Diagnostics.CodeAnalysis;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string text)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(text))
            {
                foreach (char letter in text)
                {
                    if (char.IsUpper(letter))
                    {
                       result = result.Trim();
                        result += " ";

                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }

    }
}