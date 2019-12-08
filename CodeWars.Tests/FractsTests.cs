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

        [Test]
        public void Test10()
        {
            long[,] lst = new long[,] { { 10, 20 }, { 10, 30 }, { 10, 40 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
        }

        [Test]
        public void Test100()
        {
            long[,] lst = new long[,] { { 100, 200 }, { 100, 300 }, { 100, 400 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
        }

        [Test]
        public void Test1000()
        {

            long[,] lst = new long[,] { { 1000, 2000 }, { 1000, 3000 }, { 1000, 4000 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
        }

        [Test]
        public void Test10000()
        {
            long[,] lst = new long[,] { { 10000, 20000 }, { 10000, 30000 }, { 10000, 40000 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
        }


        [Test]
        public void Test100000()
        {
            long[,] lst = new long[,] { { 100000, 200000 }, { 100000, 300000 }, { 100000, 400000 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.convertFrac(lst));
        }

        [Test]
        public void Test1000000()
        {
            long[,] lst = new long[,] { { 1000000, 2000000 }, { 1000000, 3000000 }, { 1000000, 4000000 } };
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
