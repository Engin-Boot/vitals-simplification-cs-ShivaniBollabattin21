using System;
using System.Diagnostics;
using static VitalsSimplification.VitalsChecker
using static VitalsSimplification.VitalsReport

namespace VitalsSimplification
{
     class Test
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
