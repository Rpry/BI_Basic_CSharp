namespace Static
{
    public class InstanceClass
    {
        public string Property { get; set; }

        public InstanceClass()
        {
            
        }
        
        public static string StaticProperty { get; set; }

        static InstanceClass()
        {
            
        }
    }
}