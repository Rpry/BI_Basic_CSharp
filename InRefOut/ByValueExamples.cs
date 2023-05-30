using System;

namespace InRefOut
{
    public static class ByValueExamples
    {
        public static void Run()
        {
            int number = 1;
            string s = "one";
            var obj = new MyClass { MyProp = "one" };
            Simple(number, s, obj);
            Console.WriteLine(number);
            Console.WriteLine(s);
            Console.WriteLine(obj.MyProp);
        }
        
        public static void Simple(int i, string s, MyClass obj)
        {
            i = 2;
            s = "two";
            obj.MyProp = "two";
            obj = new MyClass { MyProp = "three" };
        }
    }
}