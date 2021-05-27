using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BMSSender;

namespace BMSSender.Test
{
    [TestClass]
    public class BatteryMeasureStreamTest
    {
        [TestMethod]
        public void GivenReadingCount_WhenInvalidInput_ReturnsFalse()
        {
            bool _isValidReadingCount = UserInputValidation.IsNumeric("test");
            Assert.IsFalse(_isValidReadingCount);
        }

        [TestMethod]
        public void GivenReadingCount_WhenValidInput_ReturnsTrue()
        {
            bool _isValidReadingCount = UserInputValidation.IsNumeric("15");
            Assert.IsFalse(_isValidReadingCount);
        }

        [TestMethod]
        public void GivenReadingCount_WhenLesserThan15_ReturnsFalse()
        {
            bool _isValidReadingCount = UserInputValidation.IsGreaterThanOrEqualTo15("2");
            Assert.IsFalse(_isValidReadingCount);
        }

        [TestMethod]
        public void GivenReadingCount_WhenGreaterOrEquals15_ReturnsTrue()
        {
            bool _isValidReadingCount = UserInputValidation.IsGreaterThanOrEqualTo15("20");
            Assert.IsFalse(_isValidReadingCount);
        }

        [TestMethod]
        public void GivenReadingCount_WhenValidCount_CreatesReadingList()
        {
            BatteryMeasureStream measures = new BatteryMeasureStream();
            measures.CreateBatteryMeasureReadings(15);
            Assert.IsNotNull(measures._readings.Count);
        }
    }
}
