namespace InterfacesAndAbstractClasses;

public static class SingleImplementationClassExample1
{
    public static void RunExample()
    {
        ISimpleImplementation1Interface1 implementationClassObj1 = new SimpleImplementation1Class();
        implementationClassObj1.M1();
        implementationClassObj1.M2();
        implementationClassObj1.M3();
    }
}

public interface ISimpleImplementation1Interface1
{
    void M1()
    {
        Console.WriteLine("I1");
    }
    
    void M2()
    {
        Console.WriteLine("I1");
    }
    
    virtual void M3()
    {
        Console.WriteLine("I1");
    }
}

public class SimpleImplementation1Class : ISimpleImplementation1Interface1
{
    public void M1()
    {
        Console.WriteLine("SimpleImplementation1Class M1");
    }
    
    void ISimpleImplementation1Interface1.M2()
    {
        Console.WriteLine("ISimpleImplementation1Interface1 M2");
    }
}
