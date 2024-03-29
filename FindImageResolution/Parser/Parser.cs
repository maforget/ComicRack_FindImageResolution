﻿using System;
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
        public static bool TryGetValue(this Book book, string text, string key, ImageResolutionEventArgs e, out string value)
        {
            SimpleLogger.Info($"Parsing command text \"{text}\"");
            string doubleCheck = string.Empty;
            value = string.Empty;
            if (string.IsNullOrEmpty(text))
                return false;

            var curlyBrackets = MatchedCurlyBrackets.Parse(text);
            foreach (MatchedCurlyBrackets item in curlyBrackets)
            {
                SimpleLogger.Debug($"Parsed curly brackets \"{item.Raw}\".");
                value += item.Prefix;
                if(book.TryGetValue(item, e, out string valueBracket))
                {
                    SimpleLogger.Debug($"Parsed angle brackets \"{item?.Value?.Raw}\" and found field \"{item?.Value?.Text}\" and extracted this value: \"{valueBracket}\"");
                    if (item?.Value?.Text != key)
                        doubleCheck += valueBracket;

                    value += valueBracket;
                }
                value += item.Suffix;
            }

            var existingValue = book.GetExistingValue(key);
            if(string.IsNullOrEmpty(value) || doubleCheck == existingValue)
            {
                SimpleLogger.Warning($"Parsing failed because {(doubleCheck == existingValue ? "it would reapply the same text twice" : "the resulting text is empty")}");
                return false;
            }

            SimpleLogger.Info($"From the command text got value: \"{value}\"");
            return true;
        }

        private static bool TryGetValue(this Book book, MatchedCurlyBrackets curlyBrackets, ImageResolutionEventArgs e, out string value)
        {
            value = string.Empty;
            var angledBrackets = curlyBrackets?.Value ?? null;
            if (angledBrackets == null || string.IsNullOrEmpty(angledBrackets?.Text))
                return false;

            var isResolution = Enum.TryParse<ResolutionEnum>(angledBrackets?.Text, out _);
            string text = isResolution ? e.Get<string>(angledBrackets?.Text) : book.GetExistingValue(angledBrackets?.Text);

            if (string.IsNullOrEmpty(text)) 
                return false;

            value += angledBrackets?.Prefix;
            value += text;
            value += angledBrackets?.Suffix;
            return true;
        }
    }
}
