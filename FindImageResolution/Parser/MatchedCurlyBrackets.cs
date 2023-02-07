using FindImageResolutionNET.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FindImageResolutionNET.Parser
{
    public class MatchedCurlyBrackets : MatchedBase
    {
        public override IMatchedFields Value { get; }
        public MatchedCurlyBrackets(string text, string prefix, string suffix)
            : base(text, prefix, suffix)
        {
            Value = MatchedAngledBrackets.Parse(text).FirstOrDefault();
        }

        public static IEnumerable<IMatchedFields> Parse(string text)
        {
            Regex regex = new Regex("(?<prefix>[^}]+)*{(?<match>[^{}]+?)}(?<suffix>[^{]+)*", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return Parse<MatchedCurlyBrackets>(text, regex);
        }
    }
}
