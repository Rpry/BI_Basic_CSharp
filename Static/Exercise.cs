using System;

namespace Static
{
    public static class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("A.x = " + A.x);
            Console.WriteLine("B.y = " + B.y);
        }
    }
    
    public class A
    {
        public static int x = B.y + 1;

        static A()
        {
            
        }
    }

    public class B
    {
        public static int y = A.x + 1;

        static B()
        {
            
        }
    }
    
    //https://stackoverflow.com/questions/2784558/c-sharp-two-classes-with-static-members-referring-to-each-other
}