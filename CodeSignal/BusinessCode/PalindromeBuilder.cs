using System.Collections.Generic;
using System.Linq;

namespace BusinessCode
{
    public class PalindromeBuilder
    {
        public bool Process(string text)
        {
            return GroupByChar(text).Count(IsCharImpair) <= 1;
        }

        private static bool IsCharImpair(IGrouping<char, char> item)
        {
            return (item.Count() % 2) != 0;
        }

        private static IEnumerable<IGrouping<char, char>> GroupByChar(string text)
        {
            return text.ToCharArray().GroupBy(item => item);
        }
    }
}