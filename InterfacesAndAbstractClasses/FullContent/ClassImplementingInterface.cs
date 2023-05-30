namespace InterfacesAndAbstractClasses.FullContent;

public class ClassImplementingInterface : IInterface
{
    public string Method(string arg)
    {
        //MethodWithBody(arg);
        throw new NotImplementedException();
    }

    public string Property { get; set; }

    public event EventHandler? MyEventHandler;

    public IInterface this[int i]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}