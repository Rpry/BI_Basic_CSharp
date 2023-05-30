using System;

namespace InRefOut
{
    public static class OutExamples
    {
        public static void Run()
        {
            int number = 1;
            string s = "one";
            var obj = new MyClass { MyProp = "one" };
            Simple(out number, out s, out obj);
            Console.WriteLine(number);
            Console.WriteLine(s);
            Console.WriteLine(obj.MyProp);
        }

        private static void Simple(out int i, out string s, out MyClass obj)
        {
            i = 2;
            s = "two";
            obj = new MyClass { MyProp = "three" };
            //obj.MyProp = "two";
        }
    }
}