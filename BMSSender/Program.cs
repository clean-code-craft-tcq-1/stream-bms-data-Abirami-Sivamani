using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Battery Measure Streaming Started");
        start:
            Console.WriteLine("Please enter number of BMS readings to be streamed(Minimum 15):");
            string ReadingCount = Console.ReadLine();
            if (UserInputValidation.IsNumeric(ReadingCount) && UserInputValidation.IsGreaterThanOrEqualTo15(ReadingCount))
            {
                BatteryMeasureStream BMS = new BatteryMeasureStream();
                BMS.CreateBatteryMeasureReadings(int.Parse(ReadingCount));
                BMS.PrintBatteryMeasureReadings();
            }
            else
            {
                Console.WriteLine("Please provide the valid number!!!");
                goto start;
            }
        }
    }
}
