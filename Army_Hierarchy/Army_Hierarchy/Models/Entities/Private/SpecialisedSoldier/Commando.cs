namespace Army_Hierarchy.Models.Entities.Private.SpecialisedSoldier
{
    using System.Linq;
    using System.Collections.Generic;

    using Army_Hierarchy.Models.Contracts;
    using Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private IList<IMission> _missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary, corp)
        {
            this._missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>)this._missions;

        public void AddMission(IMission mission)
        {
            if (this._missions.FirstOrDefault(m=> m.CodeName == mission.CodeName) == null)
            {
                this._missions.Add(mission);
            }
        }
    }
}
