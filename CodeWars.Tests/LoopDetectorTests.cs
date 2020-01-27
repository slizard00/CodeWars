using NUnit.Framework;

namespace CodeWars.Tests
{
    [TestFixture]
    public class LoopDetectorTests
    {
        [Test]
        public void FourNodesWithLoopSize3()
        {
            var n1 = new LoopDetector.Node();
            var n2 = new LoopDetector.Node();
            var n3 = new LoopDetector.Node();
            var n4 = new LoopDetector.Node();
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n2;
            Assert.AreEqual(3, Kata.getLoopSize(n1));
        }

        [Test]
        public void RandomChainNodesWithLoopSize30()
        {
            var n1 = LoopDetector.createChain(3, 30);
            Assert.AreEqual(30, Kata.getLoopSize(n1));
        }

        [Test]
        public void RandomLongChainNodesWithLoopSize1087()
        {
            var n1 = LoopDetector.createChain(3904, 1087);
            Assert.AreEqual(1087, Kata.getLoopSize(n1));
        }
    }
}