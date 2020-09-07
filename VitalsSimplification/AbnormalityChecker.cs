using System;
using System.Collections.Generic;
using System.Text;

namespace VitalsSimplification
{
    class AbnormalityChecker
    {
        public static string CheckAbnormalVitalandReturnMessage(string vitalName,float vitalReading,float upperLimit, float lowerLimit)
        {
            string message = vitalName + "is Normal";
            if(vitalReading<lowerLimit)
            {
                message = vitalName + "is Low";
            }
            else if(vitalReading>upperLimit)
            {
                message = vitalName + "is High";
            }
            return message;
        }
       
    }
}
