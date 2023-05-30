using System;

namespace MethodsHideAndOverride
{
    public static class ClassInheritance
    {
        public static void RunExample()
        {
            Class1 obj1 = new Class2();
            obj1.M1();
            obj1.M2();
            
            obj1.M3();
        }
    }

    public class Class1
    {
        public void M1()
        {
            Console.WriteLine("I0");
        }
        
        public virtual void M2()
        {
            Console.WriteLine("I0");
        }
        
        public virtual void M3()
        {
            Console.WriteLine("I0");
        }
    }

    public class Class2 : Class1
    {
        public void M1()
        {
            Console.WriteLine("I1");
        }
        
        public void M2()
        {
            Console.WriteLine("I1");
        }
        
        public override void M3()
        {
            Console.WriteLine("I0");
        }
        
        public void M4()
        {
            Console.WriteLine("I0");
        }
    }    
}