using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            Class.ManyAdditionsViaListOfObjects();
            //Class.ManyAdditionsViaGenericList();
            
            stopwatch.Stop();
            Console.WriteLine ("Time taken: {0}", stopwatch.Elapsed);
        }
    }
}