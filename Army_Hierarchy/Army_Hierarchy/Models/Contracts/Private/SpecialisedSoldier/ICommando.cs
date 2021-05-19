using System.Collections.Generic;

namespace Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
