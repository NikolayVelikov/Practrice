namespace Army_Hierarchy.Core.Entities
{
    using Army_Hierarchy.Messages;
    using Army_Hierarchy.IO.Contracts;
    using Army_Hierarchy.Core.Contracts;
    using System.Linq;

    public class Engine : IEngine
    {
        private IReader _reader;
        private IWriter _writer;
        private IInterpreter _interpreter;
        public Engine(IReader reader, IWriter writer, IInterpreter interpreter)
        {
            this._reader = reader;
            this._writer = writer;
            this._interpreter = interpreter;
        }

        public void Run()
        {
            string input = string.Empty;

            while ((input = this._reader.ReadLine()) != ExpectedValues.StopInput)
            {
                string[] token = input.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                string typeOfInput = token[0];
                try
                {
                    switch (typeOfInput)
                    {
                        case ExpectedValues.Private: this._interpreter.Private(token.Skip(1).ToArray()); break;
                        case ExpectedValues.LieutenantGeneral: this._interpreter.LieutenantGeneral(token.Skip(1).ToArray()); break;
                        case ExpectedValues.Spy: this._interpreter.Spy(token.Skip(1).ToArray()); break;
                        case ExpectedValues.Engineer: this._interpreter.Engineer(token.Skip(1).ToArray()); break;
                        case ExpectedValues.Commando: this._interpreter.Commando(token.Skip(1).ToArray()); break;
                    }
                }
                catch (System.Exception)
                {
                    continue;
                }                
            }

            this._writer.WriteLine(this._interpreter.Print());
        }
    }
}
