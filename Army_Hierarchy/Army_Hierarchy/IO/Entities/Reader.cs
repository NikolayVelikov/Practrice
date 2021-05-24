namespace Army_Hierarchy.IO.Entities
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
