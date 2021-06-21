using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSSender
{
    public static class UserInputValidation
    {
        public static bool IsNumeric(string ReadingCount)
        {
            return int.TryParse(ReadingCount, out int isNumber);
        }

        public static bool IsGreaterThanOrEqualTo15(string ReadingCount)
        {
            if (int.Parse(ReadingCount) >= 15)
                return true;
            else
                return false;
        }
    }
}
