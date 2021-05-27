using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public class BatteryMeasures
    {
        public double Temperature;
        public double StateOfCharge;
        public BatteryMeasures(double temperature, double soc)
        {
            this.Temperature = temperature;
            this.StateOfCharge = soc;
        }
    }

}
