using System.Collections.Generic;

namespace Army_Hierarchy.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public ICollection<IRepair> Repairs { get; set; }
    }
}
