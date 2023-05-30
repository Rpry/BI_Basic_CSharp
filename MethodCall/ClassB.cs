using System;

namespace MethodCall
{
    public class ClassB: ClassA
    {
        //public new void Method()
        public override void Method()
        {
            Console.WriteLine("B");
        }
    }
}