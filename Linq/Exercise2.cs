using System;
using System.Linq;

namespace Linq
{
    public static class Exercise2
    {
        public static void Run()
        {
            Mat M = new Mat(); 
            var numbers = Enumerable.Range(0, 10); 
            var query = 
                (from number in numbers 
                    let number2 = M.Inc(number) 
                    where number2 % 2 != 0 
                    select number).Take(4); 
            foreach (var number in query) 
                Console.WriteLine("Number: " + number); 
        }
    }

    public class Mat
    {
        public int Inc(int x)
        {
            return x + 1;
        } 
    }
}