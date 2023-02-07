using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindImageResolutionNET.Parser
{
    public abstract class MatchedBase : IMatchedFields
    {
        public string Prefix { get; } = string.Empty;
        public string Text { get; } = string.Empty;
        public string Suffix { get; } = string.Empty;
        public abstract IMatchedFields Value { get; }

        protected MatchedBase(string text, string prefix, string suffix)
        {
            Text = text;
            Prefix = prefix;
            Suffix = suffix;
        }

        public static IEnumerable<IMatchedFields> Parse<T>(string text, Regex regex) where T : IMatchedFields
        {
            var list = new List<IMatchedFields>();
            try
            {
                Match matchResult = regex.Match(text);
                while (matchResult.Success)
                {
                    string match = matchResult.Groups["match"]?.Value;
                    string prefix = matchResult.Groups["prefix"]?.Value;
                    string suffix = matchResult.Groups["suffix"]?.Value;
                    var matched = (T)Activator.CreateInstance(typeof(T), new[] { match, prefix, suffix});
                    list.Add(matched);
                    matchResult = matchResult.NextMatch();
                }
            }
            catch (ArgumentException ex)
            {
                SimpleLogger.Error(ex.Message);
            }
            return list;
        }
    }
}