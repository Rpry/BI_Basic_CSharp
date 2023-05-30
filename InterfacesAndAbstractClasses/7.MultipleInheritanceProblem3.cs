namespace InterfacesAndAbstractClasses;

public static class MultipleInheritanceProblem3
{
    public static void RunExample()
    {
        IMip3Interface0 obj1 = new Mip3Class();
        obj1.M();
    }
}

public interface IMip3Interface0
{
    void M()
    {
        Console.WriteLine("I0");
    }
}

public interface IMip3Interface1 : IMip3Interface0
{
    //void IMip3Interface0.M()
    void M()
    {
        Console.WriteLine("I1");
    }
}

public interface IMip3Interface2 : IMip3Interface0
{
    //void IMip3Interface0.M()
    void M()
    {
        Console.WriteLine("I2");
    }
}

public interface IMip3Interface3 : IMip3Interface1, IMip3Interface2
{
    
}

public class Mip3Class : IMip3Interface3
{
}