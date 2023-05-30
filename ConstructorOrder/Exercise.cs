using System;

namespace MethodCall
{
    public static class Exercise
    {
        public static void Run()
        {
            B b = new B();
        }
    }
    
    public class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        
        static A()
        {
            Console.WriteLine("static A");
        }
    }
    public class B: A
    {
        static B()
        {
            Console.WriteLine("static B");
        }
        
        public B()
        {
            Console.WriteLine("B");
        }
    }
}