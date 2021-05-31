namespace Army_Hierarchy.Core.Contracts
{
    public interface IInterpreter
    {
        void Private(string[] input);
        void LieutenantGeneral(string[] input);
        void Engineer(string[] input);
        void Commando(string[] input);
        void Spy(string[] input);
        string Print();
    }
}
