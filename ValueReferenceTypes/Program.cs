using System;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectOfClass = new MyClass { Id = 1 };
            var objectOfStruct = new MyStruct { Id = 1 };

            var obj1 = objectOfClass;
            obj1.Id = 2;
            Console.WriteLine(objectOfClass.Id);
            
            var obj2 = objectOfStruct;
            obj2.Id = 2;
            Console.WriteLine(objectOfStruct.Id);


            string s = "one";
            string s2 = s;
            s2 = "two";
            Console.WriteLine(s);
        }
    }
}