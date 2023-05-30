using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Exercise0
    {
        public static void Run()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" }; 
            var start = "B"; 
            Console.WriteLine(list.SingleOrDefault(c => c.StartsWith(start)));
        } 
    }
}