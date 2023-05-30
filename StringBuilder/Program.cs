using System;
using System.Diagnostics;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            //Class.ManyConcatenationsViaString();
            //Class.ManyConcatenationsViaStringBuilder();

            //Class.OneConcatenationViaString();    
            Class.OneConcatenationViaStringBuilder();
            
            stopwatch.Stop();
            Console.WriteLine ("Time taken: {0}", stopwatch.Elapsed);
        }
    }
}