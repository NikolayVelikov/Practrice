namespace Army_Hierarchy.IO.Entities
{
    using System;

    using Army_Hierarchy.IO.Contracts;

    public class Writer : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        void IWriter.Write(string text)
        {
            Console.Write(text);
        }
    }
}
