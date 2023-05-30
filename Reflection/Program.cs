using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var myInstance = new MyClass()
            {
                Name = "ClassName"
            };
            var properties = myInstance.GetType().GetProperties(BindingFlags.Public|BindingFlags.Instance)
                .Select(field => field.Name)
                .ToList();
            
            var configuration = GetMapperConfiguration();
        }
        
        private static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                // Add all Profiles from the Assembly
                cfg.AddMaps(Assembly.GetExecutingAssembly());
                
                // Add all Profiles from the Assembly containingFile
                //cfg.AddMaps(typeof(MyProfile));
            });

            return configuration;
        }
    }
}