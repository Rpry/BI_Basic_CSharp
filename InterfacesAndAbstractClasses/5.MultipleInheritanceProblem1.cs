namespace InterfacesAndAbstractClasses;

public static class MultipleInheritanceProblem1
{
    public static void RunExample()
    {
        IMip1Interface0 obj1 = new Mip1Class();
        obj1.M();
    }
}

public interface IMip1Interface0
{
    void M()
    {
        Console.WriteLine("I0");
    }
}

public interface IMip1Interface1 : IMip1Interface0
{
    void M()
    {
        Console.WriteLine("I1");
    }
}

public interface IMip1Interface2 : IMip1Interface0
{
    void M()
    {
        Console.WriteLine("I2");
    }
}

public class Mip1Class : IMip1Interface1, IMip1Interface2
{
}