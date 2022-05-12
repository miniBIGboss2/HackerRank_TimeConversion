using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeConversion.UnitTests
{
    [TestFixture]
    public class ConvertToMilitaryTests
    {
        [TestMethod]
        public void ConvertToMilitaryTests_TimeIsAM_GetConverted()
        {
            // Arrange
            var input = "07:05:45AM";

            // Act
            var result = ConvertToMilitary.GetConverted(input);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
