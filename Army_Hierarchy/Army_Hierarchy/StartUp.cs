using Army_Hierarchy.Core.Entities;
using Army_Hierarchy.IO.Entities;

namespace Army_Hierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            var writer = new Writer();
            var factory = new Factory.Entities.Factory();
            var interpreter = new Interpreter(factory);

            var engine = new Engine(reader, writer, interpreter);
            engine.Run();

        }
    }
}
