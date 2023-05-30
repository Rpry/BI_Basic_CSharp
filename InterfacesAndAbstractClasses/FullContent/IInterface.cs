namespace InterfacesAndAbstractClasses.FullContent;

public interface IInterface
{
    #region Fields

    //public int Field = 1;

    //Константное поле
    public const int ConstField = 1;
    
    //public Action MyDelegate = () => {};    

    #endregion

    #region Declarations

    //Метод
    public string Method(string arg);
    //Свойство
    public string Property { get; set; }
    //Событие
    public event EventHandler MyEventHandler;
    //Индексатор
    public IInterface this[int i] { get; set; }

    #endregion

    #region Declarations and implementations

    // Метод с реализацией
    public string MethodWithBody(string s)
    {
        return s;
    }
    //Свойство
    public string PropertyWithBody
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    //event EventHandler ImplementedEventHandler  = (sender, args) => { throw new NotImplementedException(); };
    //Индексатор
    public IInterface this[int i, int j]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    #endregion

    #region Static members

    //Статический конструктор
    static IInterface()
    {
        
    }
    //Поле
    public static int StaticField = 0;
    //Делегат
    public static Action StaticDelegate;
    //Метод
    public static string StaticMethod(string s)
    {
        return s;
    }
    //Свойство
    public static string StaticProperty { get; set; }
    //Событие
    public static event EventHandler StaticEvent = (sender, args) => throw new NotImplementedException();
    //Оператор
    public static string operator + (IInterface a, IInterface b)
    {
        throw new NotImplementedException();
    }
    
    #endregion
  
    //Вложенные типы
    #region Вложенные типы

    class NestedClass
    {
        
    }

    struct NestedStruct
    {
        
    }

    interface INestedInterface
    {
        
    }

    #endregion
}
