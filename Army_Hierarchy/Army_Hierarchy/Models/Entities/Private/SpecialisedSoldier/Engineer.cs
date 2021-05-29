namespace Army_Hierarchy.Models.Entities.Private.SpecialisedSoldier
{
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    using Army_Hierarchy.Models.Contracts;
    using Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private IList<IRepair> _repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary, corp)
        {
            this._repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)this._repairs;

        public void AddRepair(IRepair repair)
        {
            if (this._repairs.FirstOrDefault(r => r.PartName == repair.PartName) == null)
            {
                this._repairs.Add(repair);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($" {repair.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
