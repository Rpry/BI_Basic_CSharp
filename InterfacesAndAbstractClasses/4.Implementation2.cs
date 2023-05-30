namespace InterfacesAndAbstractClasses;

public static class ImplementationClassExample2
{
    public static void RunExample()
    {
        Implementation2Class implementationClassObj1 = new Implementation2Class();
        //implementationClassObj1.M();
            
        IImplementation2Interface1 implementationClassObj2 = new Implementation2Class();
        implementationClassObj2.M();
            
        IImplementation2Interface2 implementationClassObj3 = new Implementation2Class();
        implementationClassObj3.M();
    }
}

public interface IImplementation2Interface1
{
    void M()
    {
        Console.WriteLine("I1");
    }
}

public interface IImplementation2Interface2
{
    void M()
    {
        Console.WriteLine("I2");
    }
}

public class Implementation2Class : IImplementation2Interface1, IImplementation2Interface2
{
    void IImplementation2Interface1.M()
    {
        Console.WriteLine("SealedClass");
    }
}
