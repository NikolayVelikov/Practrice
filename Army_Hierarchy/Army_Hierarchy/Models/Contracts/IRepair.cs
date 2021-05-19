namespace Army_Hierarchy.Models.Contracts
{
    public interface IRepair
    {
        string PartName { get; }
        int WorkedHours { get; }
    }
}
