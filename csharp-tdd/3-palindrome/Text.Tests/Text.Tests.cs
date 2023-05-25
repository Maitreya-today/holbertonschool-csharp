using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {
        const string check1 = "racecar",
            chcek2 = "Tacocat",
            check3 = "A man, a plan, a canal: Panama.",
            check4 = "NeedDeen";

        const string fail1 = "not a palindrome",
            fail2 = "HolbertonH",
            fail3 = "NotNotNot";
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(check1)]
        [TestCase(chcek2)]
        [TestCase(check3)]
        [TestCase(check4)]
        [TestCase("")]
        [TestCase(null)]
        public void PositiveResponce(string value)
        {
            Assert.IsTrue(Text.Str.IsPalindrome(value));
        }

        [TestCase(fail1)]
        [TestCase(fail2)]
        [TestCase(fail3)]
        public void NegativeResponce(string value)
        {
            Assert.IsFalse(Text.Str.IsPalindrome(value));
        }
    }
}