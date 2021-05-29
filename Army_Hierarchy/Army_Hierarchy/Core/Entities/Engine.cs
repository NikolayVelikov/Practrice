namespace Army_Hierarchy.Core.Entities
{
    using Army_Hierarchy.Core.Contracts;
    using Army_Hierarchy.IO.Contracts;

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
            throw new System.NotImplementedException();
        }
    }
}
