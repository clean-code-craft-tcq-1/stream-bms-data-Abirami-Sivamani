using BMSSender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public class TemperatureMeasure : IBMSGenerator
    {
        Random _randomNumber = new Random();
        public double BatteryMeasureValueGenerator()
        {
            return Math.Round((_randomNumber.NextDouble() * (BatteryExtremeLimit.MaxTemperature - BatteryExtremeLimit.MinTemperature) + BatteryExtremeLimit.MinTemperature), 2);
        }
    }
}
