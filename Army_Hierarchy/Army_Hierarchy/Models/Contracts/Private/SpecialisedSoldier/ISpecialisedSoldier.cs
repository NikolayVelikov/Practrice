using Army_Hierarchy.Enumerators;

namespace Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corp { get; }
    }
}
