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
                var botton = lst[i, 1];
                denominators.Add(botton);
            }

            long gcd = 1;
            denominators.Distinct().ToList().ForEach(x => gcd *= x);

            long[,] newList = (long[,])lst.Clone();
            for (int i = 0; i < lst.Length / 2; i++)
            {
                var denominator = lst[i, 1];
                var v = gcd / denominator;
                var top = lst[i, 0];
                var newtop = top * v;
                newList[i, 0] = newtop;
                newList[i, 1] = gcd;
            }

            long log = 1;
            for (int i = 2; i < gcd / 2; i++)
            {
                var eee = newList.Cast<long>().ToArray();
                if (eee.All(x => (x % i) == 0))
                {
                    log = i;
                    break;
                }
            }
            for (int i = 0; i < newList.Length / 2; i++)
            {
                newList[i, 0] = newList[i, 0] / log;
                newList[i, 1] = newList[i, 1] / log;
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