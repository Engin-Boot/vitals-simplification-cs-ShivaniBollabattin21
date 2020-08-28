using System;
using System.Diagnostics;


namespace VitalsSimplification
{
        static int Main()
        {
            VitalsReport.ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60));
            VitalsReport.ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 92));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}