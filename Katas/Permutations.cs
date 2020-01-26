using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class Permutations
    {
        public static List<string> SinglePermutations(string s)
        {
            var allCombos = BuildCombinationsRecursive("", s);
            return allCombos.Select(sb => sb.ToString()).Distinct().OrderBy(x => x).ToList();
        }
        
        private static List<StringBuilder> BuildCombinationsRecursive(string baseString, string remainingChars)
        {
            var sbList = new List<StringBuilder>();

            for (int i = 0; i <= remainingChars.Length - 1; i++)
            {
                var newBaseString = new StringBuilder(baseString);
                newBaseString.Append(remainingChars[i]);

                if (remainingChars.Length == 1)
                {
                    sbList.Add(newBaseString);
                    return sbList;
                }
                
                var sublist = BuildCombinationsRecursive(newBaseString.ToString(), GetNewRemainingCharacters(remainingChars, i));
                foreach (var item in sublist)
                    sbList.Add(item);
            }
            return sbList;
        }

        private static string GetNewRemainingCharacters(string remainingChars, int i)
        {
            var newRemainingChars = new StringBuilder();
            for (int a = 0; a <= remainingChars.Length - 1; a++)
                if (a != i) newRemainingChars.Append(remainingChars[a]);
            return newRemainingChars.ToString();
        }
    }
}
