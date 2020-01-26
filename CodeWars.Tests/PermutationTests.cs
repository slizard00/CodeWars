using Katas;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Tests
{
    class PermutationTests
    {

        [Test]
         public void Example1()
        {
            Assert.AreEqual(new List<string> { "a" }, Permutations.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example2()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, Permutations.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example3()
        {
            Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Permutations.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example4()
        {
            Assert.AreEqual(new List<string> { "abc", "acb", "bac", "bca", "cab", "cba" }, Permutations.SinglePermutations("abc").OrderBy(x => x).ToList());
        }
    }
}