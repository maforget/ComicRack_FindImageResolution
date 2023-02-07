using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindImageResolutionNET.Parser
{
    public interface IMatchedFields
    {
        string Prefix { get; }
        string Text { get; }
        string Suffix { get; }
        IMatchedFields Value { get; }
    }
}