namespace Army_Hierarchy.IO.Models
{
    using System;

    using Army_Hierarchy.IO.Contracts;

    public class Reader : IReader
    {
        public int Read()
        {
            return Console.Read();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
