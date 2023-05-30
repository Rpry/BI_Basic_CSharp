using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Exercise
    {
        public static void Run()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" }; 
            var start = "F"; 
            var query = list.Where(c => c.StartsWith(start)); 
            start = "B"; 
            query = query.Where(c => c.StartsWith(start)); 
            Console.WriteLine(query.Count());
        } 
    }
}