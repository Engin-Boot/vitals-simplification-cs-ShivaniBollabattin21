using System;
using System.Collections.Generic;
using System.Text;

namespace vitals_simplification
{
    class AbnormalityChecker
    {
        public static void checkAbnormalBPM(float bpm)
        {
            if(bpm<70)
            {
                Console.WriteLine(bpm + " BPM is Low");
            }
            else if(bpm>150)
            {
                Console.WriteLine(bpm + " BPM is High");
            }
        }

        public static void checkAbnormalSpo2(float spo2)
        {
            if(spo2<95)
            {
                Console.WriteLine(spo2+" Oxygen Saturation is Low");
            }
            else if(spo2>100)
            {
                Console.WriteLine(spo2 + " Oxygen Saturation is High");
            }
        }

        public static void checkAbnormalRespRate(float respRate)
        {
            if(respRate<30)
            {
                Console.WriteLine(respRate + " Respiratory rate is Low");
            }
            else if(respRate>95)
            {
                Console.WriteLine(respRate + " Respiratory rate is High");
            }
        }
    }
}
