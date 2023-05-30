using System;
using System.Collections;
using System.Collections.Generic;

namespace BaseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection collection = new List<string>();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            //collection[0]

            IList list = new List<string>(); 
            Console.WriteLine(list[0]);
        }
    }
}