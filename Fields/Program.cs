namespace Fields
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var constantValue = ClassA.ConstantVariable;
            
            var staticValue = ClassA.StaticVariable;
            
            var readOnlyValue = (new ClassA()).ReadOnlyVariable;
        }
    }
}