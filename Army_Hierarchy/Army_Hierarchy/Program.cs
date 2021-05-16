using Army_Hierarchy.Models;
using System;

namespace Army_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy(123, "asdas", "asdas", 145);
            Console.WriteLine(spy);
        }
    }
}
