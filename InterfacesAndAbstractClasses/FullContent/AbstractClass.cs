namespace InterfacesAndAbstractClasses.FullContent;

public abstract class AbstractClass
{
    //Конструктор
    public AbstractClass()
    {
        
    }

    #region Fields

    //Поле
    public int Field = 1;

    //Константное поле
    public const int ConstField = 1;
    
    //Делегат
    public Action MyDelegate = () => {};    

    #endregion

    #region Declarations

    //Декларация метода
    public abstract string Method(string arg);
    //Декларация свойства
    public abstract string Property { get; set; }
    //Декларация события
    public abstract event EventHandler MyEventHandler;
    //Декларация индексатора
    public abstract AbstractClass this[int i] { get; set; }

    #endregion

    #region Declarations and implementations

    //Декларация и реализация метода
    public string MethodWithBody(string arg)
    {
        return arg;
    }
    
    //Декларация и реализация свойства
    public string PropertyWithBody
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    
    //Декларация и реализация события
    public event EventHandler EventHandlerWithBody = (sender, args) => { throw new NotImplementedException(); };

    public AbstractClass this[int i, int j]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    #endregion

    #region Static members
    
    //Статический конструктор
    static AbstractClass()
    {
        
    }
    //Поле
    public static int StaticField = 0;
    //Делегат
    public static Action StaticDelegate = () => throw new NotImplementedException();
    //Метод
    public static string StaticMethod(string s)
    {
        throw new NotImplementedException();
    }
    //Свойство
    public static string StaticProperty { get; set; }
    //Событие
    public static event EventHandler StaticEventHandler = (sender, args) => throw new NotImplementedException();
    //Оператор
    public static string operator + (AbstractClass a, AbstractClass b)
    {
        throw new NotImplementedException();
    }
    #endregion
}