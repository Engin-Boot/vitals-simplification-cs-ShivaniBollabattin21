using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitalsSimplification
{
    class SPO2Checker
    {
        public static bool checkSpo2(float spo2)
        {
            if (spo2 >= 95 && spo2 <= 100)
            {
                return true;
            }
            return false;
        }
    }
}
