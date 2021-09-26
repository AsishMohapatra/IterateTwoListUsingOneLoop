using System;
using System.Collections.Generic;
using System.Linq;

namespace IterateTwoList
{
    class Program
    {
        static List<int> ids = new List<int>(new[] { 1, 2, 3, 4 });
        static List<string> names = new List<string>(new[] { "A", "B", "C", "D" });
        public static void Main(string[] args)
        {
            var result = ids.Zip(names, (x, y) => new { Id = x, Name = y });
            result.ToList().ForEach(x => Console.WriteLine($"Id = {x.Id} and Name  {x.Name}"));
        }
    }
}
