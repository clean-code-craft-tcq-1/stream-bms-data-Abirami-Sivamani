using BMSSender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public class SOCMeasure : IBMSGenerator
    {
        Random _randomNumber = new Random();
        public double BatteryMeasureValueGenerator()
        {
            return Math.Round((_randomNumber.NextDouble() * (BatteryExtremeLimit.MaxSoc - BatteryExtremeLimit.MinSoc) + BatteryExtremeLimit.MinSoc), 2);
        }
    }
}
