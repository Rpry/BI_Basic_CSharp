using System;

namespace InRefOut
{
    public static class RefExamples
    {
        public static void Run()
        {
            int number = 1;
            string s = "one";
            var obj = new MyClass { MyProp = "one" };
            Simple(ref number, ref s, ref obj);
            Console.WriteLine(number);
            Console.WriteLine(s);
            Console.WriteLine(obj.MyProp);
        }

        private static void Simple(ref int i, ref string s, ref MyClass obj)
        {
            i = 2;
            s = "two";
            obj.MyProp = "two";
            obj = new MyClass { MyProp = "three" };
        }
    }
}