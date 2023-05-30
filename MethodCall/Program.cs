namespace MethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassB();
            obj.Method();
        }
    }
}