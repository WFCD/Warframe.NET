using System;

namespace WarframeNET
{
    internal static class Functions
    {
        public static string ToCamel(string text)
        {
            char firstCamel = text[0];
            firstCamel = char.ToLower(firstCamel);
            string final = $"{firstCamel}";

            for (int i = 1; i < text.Length; i++)
            {
                final += text[i];
            }

            return final;
        }
    }
}