using System;

namespace Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            var lazyString = new Lazy<string>(
                () =>
                {
                    // Here you can do some complex processing
                    // and then return a value.
                    Console.WriteLine("Inside lazy loader");
                    return "Lazy loading!";
                });
	
            Console.Write("Is value created: ");
            Console.WriteLine(lazyString.IsValueCreated);
	 
            var value = lazyString.Value;
            Console.Write("Value: ");
            Console.WriteLine(value);
	 	 
            Console.Write("Value again: ");
            Console.WriteLine(lazyString.Value);
	 
            Console.Write("Is value created: ");
            Console.WriteLine(lazyString.IsValueCreated);        }
    }
}