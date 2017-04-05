using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace BootcampFour
{
    public class NUnitTests
    {
        [TestFixture]
        public class FizzBuzzPrintTest
        {
            FizzBuzzPrint x = new FizzBuzzPrint();

            [Test]
            public void Test_3()
            {
                var result = x.print(3);
                Assert.AreEqual("Fizz", result);
            }

            [Test]
            public void Test_5()
            {
                var result = x.print(5);
                Assert.AreEqual("Buzz", result);
            }

            [Test]
            public void Test_30()
            {
                var result = x.print(30);
                Assert.AreEqual("FizzBuzz", result);
            }

            [Test]
            public void Test_27()
            {
                var result = x.print(27);
                Assert.AreEqual("Fizz", result);
            }

            [Test]
            public void Test_16()
            {
                var result = x.print(16);
                Assert.AreEqual("16", result);
            }

            [Test]
            public void Test_42()
            {
                var result = x.print(42);
                Assert.AreEqual("Fizz", result);
            }

        }
    }
}
