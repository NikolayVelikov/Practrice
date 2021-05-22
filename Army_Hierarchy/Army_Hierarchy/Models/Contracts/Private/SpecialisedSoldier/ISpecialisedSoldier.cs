namespace Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier
{
    using Army_Hierarchy.Enumerators;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corp { get; }
    }
}
