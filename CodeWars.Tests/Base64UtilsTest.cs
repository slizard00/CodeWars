using Katas;
using NUnit.Framework;


namespace CodeWars.Tests
{
    [TestFixture]
    public class Base64UtilsTest
    {
        [TestCase("this is a string!!", "dGhpcyBpcyBhIHN0cmluZyEh")]
        [TestCase("ee", "ZWU=")]
        [TestCase("e", "ZQ==")]
        [TestCase("", "")]
        public void SampleValueEncodeTest(string value, string expected)
        {
            Assert.AreEqual(expected, Base64Utils.ToBase64(value));
        }

        [TestCase("dGhpcyBpcyBhIHN0cmluZyEh", "this is a string!!")]
        [TestCase("ZWU=", "ee")]
        [TestCase("ZQ==", "e")]
        [TestCase("", "")]
        public void SampleValueDecodeTest(string value, string expected)
        {
            Assert.AreEqual(expected, Base64Utils.FromBase64(value));
        }
    }
}
