using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Reduced_String;
namespace Super_Reduced_String_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckStringEmpty()
        {
            //arrange
            string value = "abba";
            string expected = "Empty String";

            //action
            var reducedString = new Program().SuperReduceString(value);

            //assert
            Assert.AreEqual(expected, reducedString);
        }

        [TestMethod]
        public void DoubleCharacterBeginning()
        {
            //arrange
            string value = "aabc";
            string expected = "bc";

            //action
            var reducedString = new Program().SuperReduceString(value);

            //assert
            Assert.AreEqual(expected, reducedString);
        }

        [TestMethod]
        public void DoubleCharacterEnd()
        {
            //arrange
            string value = "abcdd";
            string expected = "abc";

            //action
            var reducedString = new Program().SuperReduceString(value);

            //assert
            Assert.AreEqual(expected, reducedString);
        }

        [TestMethod]
        public void DoubleCharacterMid()
        {
            //arrange
            string value = "abbc";
            string expected = "ac";

            //action
            var reducedString = new Program().SuperReduceString(value);

            //assert
            Assert.AreEqual(expected, reducedString);
        }

        

        [TestMethod]
        public void NoDoubleCharactere()
        {
            //arrange
            string value = "mwkommokwmxjivkkvijxshscbbcshsgwdyqqydwgzpnlzzlnpzvfeaiiaefvyeqjccjqeymhqhiihqhmhaomkkmoahhddymmyddh";
            string expected = "Empty String";

            //action
            var reducedString = new Program().SuperReduceString(value);

            //assert
            Assert.AreEqual(expected, reducedString);
        }

    }
}
