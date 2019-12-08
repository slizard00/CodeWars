using NUnit.Framework;


namespace CodeWars.Tests
{


    [TestFixture]
    public class FractsTests
    {

        [Test]
        public void Test1()
        {

            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));

        }

        //[Test]
        public void Test2()
        {
            //(18078, 34060)(2262, 34060)(25545, 34060)
            long[,] lst = new long[,] { { 18078, 34060 }, { 2262, 34060 }, { 25545, 34060 } };
            Assert.AreEqual("(18078,34060)(2262,34060)(25545,34060)", Fracts.convertFrac(lst));

        }
    }
}
