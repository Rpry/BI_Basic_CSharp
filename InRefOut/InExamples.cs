using System;

namespace InRefOut
{
    public static class InExamples
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
        
        public static void Simple(in int i, in string s, in MyClass obj)
        {
            //i = 2;
            //s = "two";
            obj.MyProp = "two";
            //obj = new MyClass { MyProp = "three" };
        }
    }
}