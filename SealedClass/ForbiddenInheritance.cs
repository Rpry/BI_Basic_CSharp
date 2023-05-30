namespace Class;

public static class ForbiddenInheritance
{
    public static void RunExample()
    {
    }
}

public class Class
{
    
}

public sealed class SealedClass
{
    
}

public struct Struct
{
    
}

//public class ClassB : ClassA
//public class ClassB : Struct
public class InheritingClass : Class
{
    
}


