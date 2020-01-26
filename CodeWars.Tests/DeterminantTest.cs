using NUnit.Framework;
using Katas;

namespace CodeWars.Tests
{


    [TestFixture]
    class DeterminantTest
    {
        private static int[][][] matrix =
{
        new int[][] { new [] { 13 } },

        new int[][] {   new [] { 1, 3 },
                        new [] { 2, 5 } },

        new int[][] {   new [] { 2, 5, 3 },
                        new [] { 1, -2, -1 }, 
                        new [] { 1, 3, 4 } },

        new int[][] {   new [] { 2, 5, 3, 1 },
                        new [] { 1, -2, -1, 1 },
                        new [] { 1, 3, 4, 1 },
                        new [] { 1, 2, 3, 4 } },

        new int[][] { new [] { 2,  5,  3,  1,  6 }, 
                      new [] { 1, -2, -1, 11,  9 }, 
                      new [] { 1,  3,  4,  1,  3 }, 
                      new [] { 1,  2,  3,  4, -8 },
                      new [] { 9, -2,  7, -7, -5 }, },

        //new int[][] { new [] {  2,   5,   3, 12,  6, 32 },
        //              new [] { 20,  -2, -19, 11,  9, -31 },
        //              new [] { 19,   3,   4,  3, 35, -7 },
        //              new [] { 77,   2,  33,  4, -8, 23 },
        //              new [] {  9,  -2,   7, 37, -5, 14 },
        //              new [] { -91, 42,  32, -7, -5, 3 }, },
        };
        //3918523548
       
        private static int[] expected = { 13, -1, -20, -60, 19392 };

        private static string[] msg = { 
            "Determinant of a 1 x 1 matrix yields the value of the one element", 
            "Should return 1 * 5 - 3 * 2 == -1 ", 
            "", 
            "",
            "",
            ""};

        [Test]
        public void SampleTests()
        {
            for (int n = 0; n < expected.Length; n++)
                Assert.AreEqual(expected[n],Matrix.Determinant(matrix[n]), msg[n]);
        }


    }
}
