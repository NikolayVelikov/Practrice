namespace Army_Hierarchy.IO.Entities
{
    using System;

    using Army_Hierarchy.IO.Contracts;

    public class Write : IWrite
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        void IWrite.Write(string text)
        {
            Console.Write(text);
        }
    }
}
