using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<MyClass>()
            {
                new MyClass() { Id = 1, Name = "Ivan", BirthDate = DateTime.Parse("15.04.1980"), isDeleted = false},
                new MyClass() { Id = 2, Name = "Petr", BirthDate = DateTime.Parse("1.01.1982"), isDeleted = false},
                new MyClass() { Id = 3, Name = "Boris", BirthDate = DateTime.Parse("19.07.1985"), isDeleted = false},
                new MyClass() { Id = 4, Name = "Denis", BirthDate = DateTime.Parse("16.02.1990"), isDeleted = true},
                new MyClass() { Id = 5, Name = "Anatoly", BirthDate = DateTime.Parse("11.03.1975"), isDeleted = false},
            };

            var notDeleted = list.Where(l => !l.isDeleted).ToList();
            
            var idsOfNotDeleted = list
                .Where(m => !m.isDeleted)
                .Select(m=>m.Id)
                .ToList();
            
            var top2IdsOfNotDeleted = list
                .Where(m => !m.isDeleted)
                .OrderBy(m=> m.Name)
                .Select(m=> m.Name)
                .Take(2)
                .ToList();
            
            //Exercise0.Run();
            Exercise.Run();
            Exercise2.Run();
        }
    }
}