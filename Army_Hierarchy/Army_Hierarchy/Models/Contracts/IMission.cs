namespace Army_Hierarchy.Models.Contracts
{
    using Army_Hierarchy.Enumerators;

    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
