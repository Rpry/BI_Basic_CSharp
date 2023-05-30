namespace InterfacesAndAbstractClasses;

public static class ImplementationClassExample1
{
    public static void RunExample()
    {
        Implementation1Class implementationClassObj1 = new Implementation1Class();
        implementationClassObj1.M();
            
        IImplementation1Interface1 implementationClassObj2 = new Implementation1Class();
        implementationClassObj2.M();
            
        IImplementation1Interface2 implementationClassObj3 = new Implementation1Class();
        implementationClassObj3.M();
        
        Implementation1Class implementationClassObj4 = new Implementation1Class();
        //implementationClassObj1.M2();
    }
}

public interface IImplementation1Interface1
{
    void M()
    {
        Console.WriteLine("I1");
    }

    void M2();
}

public interface IImplementation1Interface2
{
    void M()
    {
        Console.WriteLine("I2");
    }
    
    void M2();
}

public class Implementation1Class : IImplementation1Interface1, IImplementation1Interface2
{
    public void M()
    {
        Console.WriteLine("SealedClass");
    }

    void IImplementation1Interface2.M2()
    {
        throw new NotImplementedException();
    }

    void IImplementation1Interface1.M2()
    {
        throw new NotImplementedException();
    }
}
