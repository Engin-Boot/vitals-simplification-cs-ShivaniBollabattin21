using System;
using System.Diagnostics;

class Checker
{
    static int Main(string[] args)
        {
            VitalsReport.ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60));
            VitalsReport.ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 92));
            Console.WriteLine("All ok");
            return 0;
        }
}

class VitalsChecker
    {
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
           if ((bpm >= 60 && bpm <= 100) && (spo2 >= 95 && spo2<=100  ) && (respRate >=30 || respRate <= 95))
            {
                return true;
            }
            return false;

        }
    }

 class VitalsReport
    {
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
    }
