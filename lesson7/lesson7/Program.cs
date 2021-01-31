using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson7
{
    class Program
    {
        static List<int> Filter(List<int> list, Func<int, bool> function)
        {
            var result = new List<int>();

            foreach (var i in list)
            {
                if (function(i))
                    result.Add(i);  
                
            }
            return result;
        }

        static Action<string> print= s => Console.WriteLine(s);

        static void Main(string[] args)
        {
            print("Hello world!");

            Console.Read();
        }
    }
}
