namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // call
            //var prop1 = (new InstanceClass()).Property;
            //var prop2 = StaticClass.StaticProperty;
            
            //ctor order for instance 
            //var obj1 = new InstanceClass();
            //var prop3 = InstanceClass.StaticProperty;
            
            //ctor order for static
            //var prop4 = StaticClass.StaticProperty;

            //Extension methods
            var instanceClassObj = new InstanceClass();
            instanceClassObj.ExtensionMethod("a");

            Exercise.Run();
        }
    }
}