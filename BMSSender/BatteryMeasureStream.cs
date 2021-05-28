using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public class BatteryMeasureStream
    {
        Random _randomNumber = new Random();
        public List<BatteryMeasures> _readings = new List<BatteryMeasures>();
        public void CreateBatteryMeasureReadingsList(int Readingcount)
        {
            for (int count = 1; count <= Readingcount; count++)
            {
                double Temp = GenerateBatteryTemperatureValue();
                double Soc = GenerateBatterySOCValue();
                _readings.Add(new BatteryMeasures(Temp, Soc));
            }
        }

        public double GenerateBatteryTemperatureValue()
        {
            return Math.Round((_randomNumber.NextDouble() * (BatteryExtremeLimit.MaxTemperature - BatteryExtremeLimit.MinTemperature) + BatteryExtremeLimit.MinTemperature), 2);
        }
        
        public double GenerateBatterySOCValue()
        {
            return Math.Round((_randomNumber.NextDouble() * (BatteryExtremeLimit.MaxSoc - BatteryExtremeLimit.MinSoc) + BatteryExtremeLimit.MinTemperature), 2);
        }

        public void PrintBatteryMeasureReadings()
        {
            foreach (var _batteryReadings in _readings)
            {
                Console.WriteLine("Temperature: " + _batteryReadings.Temperature + " SOC: " + _batteryReadings.StateOfCharge);
            }
        }
    }

    public static class BatteryExtremeLimit
    {
        public static double MaxTemperature = 40;
        public static double MinTemperature = 0;
        public static double MaxSoc = 80;
        public static double MinSoc = 20;
    }
}
