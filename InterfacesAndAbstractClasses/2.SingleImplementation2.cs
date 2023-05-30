namespace InterfacesAndAbstractClasses;

public static class SingleImplementationClassExample2
{
    public static void RunExample()
    {
        
        ISimpleImplementation2Interface1 implementationClassObj1 = new SimpleImplementation2Class();
        implementationClassObj1.M1();
        implementationClassObj1.M2();
        implementationClassObj1.M3();
        
        ISimpleImplementation2Interface2 implementationClassObj2 = new SimpleImplementation2Class();
        implementationClassObj2.M1();
        implementationClassObj2.M2();
        implementationClassObj2.M3();
    }
}

public interface ISimpleImplementation2Interface1
{
    void M1()
    {
        Console.WriteLine("I1");
    }
    
    void M2()
    {
        Console.WriteLine("I1");
    }
    
    void M3()
    {
        Console.WriteLine("I1");
    }
}

public interface ISimpleImplementation2Interface2 : ISimpleImplementation2Interface1
{
    void M1()
    {
        Console.WriteLine("I1");
    }
    
    new void M2()
    {
        Console.WriteLine("I1");
    }
    
    void ISimpleImplementation2Interface1.M3()
    {
        Console.WriteLine("I1");
    }
}

public class SimpleImplementation2Class : ISimpleImplementation2Interface2
{
}
