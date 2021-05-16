namespace Army_Hierarchy.Contracts
{
    public interface IRepair : ISpecialisedSoldier
    {
        public string PartName { get; set; }
        public int WorkedHours { get; set; }
    }
}
