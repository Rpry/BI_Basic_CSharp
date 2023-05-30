using System;
using System.Diagnostics;
using System.Threading;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Class.CastingIntToLong();
            //Class.CastingIntToObject();
            
            stopwatch.Stop();
            Console.WriteLine ("Time taken: {0}", stopwatch.Elapsed);    
            
            //Thread.Sleep(TimeSpan.FromSeconds(5));

            Exercise.Run();
        }
    }
}