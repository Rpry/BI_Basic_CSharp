using System;

namespace BoxingUnboxing
{
    public static class Exercise
    {
        public static void Run()
        {
            int a = 2; 
            Object o = a; 
            a = 4; 
            Console.WriteLine(a); 
            Console.WriteLine(o);
        }
    }
}