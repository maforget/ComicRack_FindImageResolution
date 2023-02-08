using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FindImageResolutionNET.ComicRack;
using FindImageResolutionNET.Tools;

namespace FindImageResolutionNET.Parser
{
    public static class Parser
    {
        public static bool TryGetValue(this Book book, string text, ImageResolutionEventArgs e, out string value)
        {
            value = string.Empty;
            if (string.IsNullOrEmpty(text))
                return false;

            var curlyBrackets = MatchedCurlyBrackets.Parse(text);
            foreach (MatchedCurlyBrackets item in curlyBrackets)
            {
                value += item.Prefix;
                if(book.TryGetValue(item, e, out string valueBracket))
                    value += valueBracket;
                value += item.Suffix;
            }

            if(string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        private static bool TryGetValue(this Book book, MatchedCurlyBrackets curlyBrackets, ImageResolutionEventArgs e, out string value)
        {
            value = string.Empty;
            var angledBrackets = curlyBrackets?.Value ?? null;
            if (angledBrackets == null || string.IsNullOrEmpty(angledBrackets?.Text))
                return false;

            var isResolution = Enum.TryParse<ResolutionEnum>(angledBrackets?.Text, out _);

            string text = isResolution ? e.Get<string>(angledBrackets?.Text)
                            : book.GetValue<string>(angledBrackets?.Text) ?? book.GetCustomValue(angledBrackets?.Text);

            if (string.IsNullOrEmpty(text)) 
                return false;

            value += angledBrackets?.Prefix;
            value += text;
            value += angledBrackets?.Suffix;
            return true;
        }
    }
}
