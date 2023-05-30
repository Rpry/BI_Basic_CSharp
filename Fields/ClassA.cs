namespace Fields;

public class ClassA
{
    public const string ConstantVariable = "constantValue";
    
    public readonly string ReadOnlyVariable = "readOnlyValue";
    
    public static string StaticVariable = "staticValue";

    public ClassA()
    {
        ReadOnlyVariable = "readOnlyValueFromConstructor";
    }

    public void Method()
    {
        //ReadOnlyVariable = "1";
        StaticVariable = "1";
        //ConstantVariable = "1";
    }
    
    static ClassA()
    {
        
    }
}

class B
{
    
}