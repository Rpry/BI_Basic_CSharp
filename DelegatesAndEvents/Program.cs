using System;
using DelegatesAndEvents.Event;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            int Method(int x, int y)
            {
                return x + y;
            }
            /*
            var result = UsingDelegate.RunActionAndWriteToConsole(1, 1, Method);
            Console.WriteLine(result);
            
            result = UsingDelegate.RunActionAndWriteToConsole(1, 1, delegate(int x, int y) { return x + y; });
            Console.WriteLine(result);
            
            result = UsingDelegate.RunActionAndWriteToConsole(1, 1, (x, y) => x + y);
            Console.WriteLine(result);
            */
            
            Enclosure.RunExample();
            
            
            
            var order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            order.Create();
            
            Exercise.Run();
        }
    }
}