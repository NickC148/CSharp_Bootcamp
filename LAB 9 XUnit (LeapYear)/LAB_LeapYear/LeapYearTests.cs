using Xunit;

namespace LAB_LeapYear
{
    public class LeapYearTests
    {
        LeapYears leap = new LeapYears();

        [Fact]
        public void Test_2000() //True
        {
            var result = leap.YearTest(2000);
            Assert.True(result);
        }

        [Theory]
        [InlineData(1804)] //True
        [InlineData(1856)] //True
        [InlineData(1991)] //False
        [InlineData(1998)] //False
        [InlineData(1904)] //True
        [InlineData(2005)] //False
        public void Theory_For_Leap_Years(int value)
        {
            var result = leap.YearTest(value);
            Assert.True(result);
        }

    }
}
