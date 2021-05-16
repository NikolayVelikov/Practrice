using Army_Hierarchy.Enumeration;

namespace Army_Hierarchy.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        public string CodeName { get; set; }
        public State State { get; set; }
        public void CompleteMission();
    }
}
