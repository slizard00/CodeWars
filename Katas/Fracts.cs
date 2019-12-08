using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Fracts
    {
        public static string convertFrac(long[,] lst)
        {
            var denominators = new List<long>();
            for (int i = 0; i < lst.Length / 2; i++)
            {
                var denominator = lst[i, 1];
                denominators.Add(denominator);
            }

            long gcd = 1;
            denominators.Distinct().ToList().ForEach(x => gcd *= x);

            long[,] newList = (long[,])lst.Clone();
            for (int i = 0; i < lst.Length / 2; i++)
            {
                var denominator = lst[i, 1];
                var temp = gcd / denominator;
                var top = lst[i, 0];
                newList[i, 0] = top * temp;
                newList[i, 1] = gcd;
            }

            long gcdReducer = 1;
            var allNumbersFlattened = newList.Cast<long>().ToArray().Distinct();

            var seed = gcd;
            var found = false;
            var ii = 1;
            do
            {
                if (allNumbersFlattened.All( x=> (x % seed) == 0 ))
                {
                    found = true;
                    gcdReducer = seed;
                }
                else
                {
                    seed = gcd / ++ii;
                }
            } while (!found && (seed > 0));

            if (gcdReducer != 1)
            {
                for (int i = 0; i < newList.Length / 2; i++)
                {
                    newList[i, 0] = newList[i, 0] / gcdReducer;
                    newList[i, 1] = newList[i, 1] / gcdReducer;
                }
            }

            var output = string.Empty;
            for (int i = 0; i < newList.Length / 2; i++)
            {
                output += $"({newList[i, 0]},{newList[i, 1]})";
            }
            return output;
        }
    }
}
