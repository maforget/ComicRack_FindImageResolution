using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FindImageResolutionNET.ComicRack;

namespace FindImageResolutionNET.Parser
{
    public static class Parser
    {
        public static bool TryGetValue(this Book book, string text, out string value)
        {
            value = string.Empty;
            if (string.IsNullOrEmpty(text))
                return false;

            var curlyBrackets = MatchedCurlyBrackets.Parse(text);
            foreach (MatchedCurlyBrackets item in curlyBrackets)
            {
                value += item.Prefix;
                if(book.TryGetValue(item, out string valueBracket))
                    value += valueBracket;
                value += item.Suffix;
            }

            if(string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        private static bool TryGetValue(this Book book, MatchedCurlyBrackets curlyBrackets, out string value)
        {
            value = string.Empty;
            var angledBrackets = curlyBrackets?.Value ?? null;
            if (angledBrackets == null || string.IsNullOrEmpty(angledBrackets?.Text))
                return false;

            string text = (angledBrackets?.Text.ToLower() == "width" || angledBrackets?.Text.ToLower() == "height")
                            ? $"<{angledBrackets?.Text}>"
                            : book.GetValue<string>(angledBrackets?.Text);

            if (string.IsNullOrEmpty(text)) 
                return false;

            value += angledBrackets?.Prefix;
            value += text;
            value += angledBrackets?.Suffix;
            return true;
        }
    }
}
