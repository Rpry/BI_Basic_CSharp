namespace InterfacesAndAbstractClasses;

public static class MultipleInheritanceProblem2
{
    public static void RunExample()
    {
        IMip2Interface0 obj1 = new Mip2Class();
        obj1.M();
    }
}

public interface IMip2Interface0
{
    void M()
    {
        Console.WriteLine("I0");
    }
}

public interface IMip2Interface1 : IMip2Interface0
{
    void IMip2Interface0.M()
    {
        Console.WriteLine("I1");
    }
}

public interface IMip2Interface2 : IMip2Interface0
{
    void IMip2Interface0.M()
    {
        Console.WriteLine("I2");
    }
}

public class Mip2Class : IMip2Interface1, IMip2Interface2
{
    public void M()
    {
        Console.WriteLine("classM");
    }
}