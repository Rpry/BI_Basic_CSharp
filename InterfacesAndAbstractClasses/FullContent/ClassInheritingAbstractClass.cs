namespace InterfacesAndAbstractClasses.FullContent;

public class ClassInheritingAbstractClass : AbstractClass
{
    public override string Method(string arg)
    {
        //MethodWithBody(arg);
        throw new NotImplementedException();
    }

    public override string Property { get; set; }
    public override event EventHandler MyEventHandler;

    public override AbstractClass this[int i]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}