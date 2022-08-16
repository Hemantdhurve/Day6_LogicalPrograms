using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgram
{
    public class StopWatch
    {
        public static void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            //used stopwatch class to get elapsed time
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}