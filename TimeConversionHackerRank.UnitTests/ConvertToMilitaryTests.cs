using NUnit.Framework;

namespace TimeConversionHackerRank.UnitTests
{
    [TestFixture]
    public class ConvertToMilitaryTests
    {
        [TestCase("07:05:45AM", ExpectedResult = "07:05:45")]
        [TestCase("12:01:00AM", ExpectedResult = "00:01:00")]
        public string ConvertToMilitaryTests_TimeIsAM_GetConverted(string input)
        {
            // Arrange

            // Act

            // Assert
            return ConvertToMilitary.GetConverted(input);
        }

        [TestCase("07:05:45PM", ExpectedResult = "19:05:45")]
        [TestCase("12:01:00PM", ExpectedResult = "12:01:00")]
        public string ConvertToMilitaryTests_TimeIsPM_GetConverted(string input)
        {
            // Arrange

            // Act

            // Assert
            return ConvertToMilitary.GetConverted(input);
        }
    }
}
