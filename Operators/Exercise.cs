using System;

namespace Operators
{
    public static class Exercise
    {
        public static void Run()
        {
            //Console.WriteLine(IsA() || IsB());
            Console.WriteLine(IsA() | IsB());
        }

        private static bool IsA()
        {
            return true;
        }

        private static bool IsB()
        {
            return true;
        }
    }
}