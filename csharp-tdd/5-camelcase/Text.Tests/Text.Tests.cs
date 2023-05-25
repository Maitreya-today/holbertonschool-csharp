using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("one", ExpectedResult = 1)]
        [TestCase("oneTwo", ExpectedResult = 2)]
        [TestCase("oneTwoThree", ExpectedResult = 3)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase(null, ExpectedResult = 0)]
        public int TestCases(string value)
        {
            return Str.CamelCase(value);
        }
    }
}