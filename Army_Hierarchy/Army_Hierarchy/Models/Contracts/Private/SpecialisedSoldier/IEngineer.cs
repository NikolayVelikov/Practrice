using System.Collections.Generic;

namespace Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
