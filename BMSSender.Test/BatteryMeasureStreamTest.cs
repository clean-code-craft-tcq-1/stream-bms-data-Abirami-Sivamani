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
            Assert.IsTrue(_isValidReadingCount);
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
            Assert.IsTrue(_isValidReadingCount);
        }

        [TestMethod]
        public void GivenReadingCount_WhenValidCount_CreatesReadingList()
        {
            BatteryMeasureStream measures = new BatteryMeasureStream();
            measures.CreateBatteryMeasureReadingsList(15);
            Assert.IsTrue(measures._readings.Count >= 15);
        }

        [TestMethod]
        public void GenerateTemperatureValue_ReturnsDoubleTypeValueWithinExtremeLimits()
        {
            TemperatureMeasure batteryMeasure = new TemperatureMeasure();
            double _temp = batteryMeasure.BatteryMeasureValueGenerator();
            Assert.IsTrue(BatteryExtremeLimit.MaxTemperature > _temp && BatteryExtremeLimit.MinTemperature < _temp );
        }

        [TestMethod]
        public void GenerateSOCValue_ReturnsDoubleTypeValueWithinExtremeLimits()
        {
            SOCMeasure batteryMeasure = new SOCMeasure();
            double _soc = batteryMeasure.BatteryMeasureValueGenerator();
            Assert.IsTrue(BatteryExtremeLimit.MaxSoc > _soc && BatteryExtremeLimit.MinSoc <  _soc);
        }
    }
}
