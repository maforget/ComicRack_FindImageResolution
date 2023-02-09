using FindImageResolutionNET.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FindImageResolutionNET.Parser
{
    public class MatchedAngledBrackets : MatchedBase
    {
        public override IMatchedFields Value { get; }

        public MatchedAngledBrackets(string text, string prefix, string suffix, string raw)
            :base(text, prefix, suffix, raw)
        {

        }

        public static IEnumerable<IMatchedFields> Parse(string text)
        {
            Regex regex = new Regex("(?<prefix>[^>]+)*<(?<match>[^<>]+?)>(?<suffix>[^<]+)*$", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return Parse<MatchedAngledBrackets>(text, regex);
        }
    }
}
