using Army_Hierarchy.Enumerators;

namespace Army_Hierarchy.Models.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
