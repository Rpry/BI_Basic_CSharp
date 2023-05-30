using System;
using System.Collections.Generic;

namespace DelegatesAndEvents
{
    public static class Enclosure
    {
        delegate void Printer();
        
        public static void RunExample()
        {
            List<Printer> printers = new List<Printer>(); 
            for (int counter = 0; counter < 10; counter++) 
            {
                printers.Add(delegate { Console.WriteLine(counter); }); 
            }     
            foreach (var printer in printers) 
            { 
                printer(); 
            }
        }
    }
}