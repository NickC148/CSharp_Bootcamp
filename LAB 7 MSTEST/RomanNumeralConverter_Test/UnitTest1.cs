using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;

namespace RomanNumeralConverter_Test
{
    [TestClass]
    public class TestsWithNumbers
    {
        [TestMethod]
        public void Number_Equals_1_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("I");

            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void Number_Equals_4_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("IV");

            Assert.AreEqual(result, "4");
        }

        [TestMethod]
        public void Number_Equals_7_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("VII");

            Assert.AreEqual(result, "7");
        }

        [TestMethod]
        public void Number_Equals_10_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("X");

            Assert.AreEqual(result, "10");
        }

        [TestMethod]
        public void Number_Equals_599_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("DXCIX");

            Assert.AreEqual(result, "599");
        }

        //Incorrect Notation for 599
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Number_Equals_Incorrect_599_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("DLXXXXVIIII");
        }

        [TestMethod]
        public void Number_Equals_2017_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("MMXVII");

            Assert.AreEqual(result, "2017");
        }

        [TestMethod]
        public void Number_Equals_3999_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("MMMCMXCIX");

            Assert.AreEqual(result, "3999");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Number_Equals_Blank_TestMethod()
        {
            var converter = new ArabicNumeralConverter();
            var result = converter.ConvertRomanNumeral("");
        }

    }
}
