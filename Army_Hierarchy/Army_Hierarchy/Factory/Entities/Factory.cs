namespace Army_Hierarchy.Factory.Entities
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Army_Hierarchy.Factory.Contracts;

    using Army_Hierarchy.Models.Contracts;
    using Army_Hierarchy.Models.Entities;
    using Army_Hierarchy.Models.Entities.Private;
    using Army_Hierarchy.Models.Contracts.Private;
    using Army_Hierarchy.Models.Contracts.Spy;
    using Army_Hierarchy.Models.Entities.Spy;
    using Army_Hierarchy.Models.Contracts.Private.LieutenantGeneral;
    using Army_Hierarchy.Models.Entities.Private.LieutenantGeneral;
    using Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier;
    using Army_Hierarchy.Models.Entities.Private.SpecialisedSoldier;

    public class Factory : IFactory
    {
        private IList<ISoldier> _soldiers;
        private IList<IPrivate> _privates;

        public Factory()
        {
            this._soldiers = new List<ISoldier>();
            this._privates = new List<IPrivate>();
        }

        public void Private(string id, string firstName, string lastName, decimal salary)
        {
            IPrivate @private = new Private(id, firstName, lastName, salary);

            this._privates.Add(@private);
            this._soldiers.Add(@private);
        }

        public void Spy(string id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(id, firstName, lastName, codeNumber);

            this._soldiers.Add(spy);
        }

        public void LieutenantGeneralWithOfficers(string id, string firstName, string lastName, decimal salary, string[] ids)
        {
            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);
                        
                List<IPrivate> privates = this._privates.Where(p => ids.Contains(p.Id)).ToList();

                foreach (IPrivate @private in privates)
                {
                    general.Add(@private);
                }            

            this._soldiers.Add(general);
        }
        public void LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
        {
            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

            this._soldiers.Add(general);
        }

        public void Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<IRepair> repairs)
        {
            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            foreach (IRepair repair in repairs)
            {
                engineer.AddRepair(repair);
            }

            this._privates.Add(engineer);
            this._soldiers.Add(engineer);
        }
        public IRepair Repair(string partName, int workedHours)
        {
            IRepair repair = new Repair(partName, workedHours);

            return repair;
        }

        public void Commando(string id, string firstName, string lastName, decimal salary, string corps, List<IMission> missions)
        {
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            foreach (IMission mission in missions)
            {
                commando.AddMission(mission);
            }

            this._privates.Add(commando);
            this._soldiers.Add(commando);
        }
        public IMission Mission(string codeName, string state)
        {
            IMission mission = new Mission(codeName, state);

            return mission;
        }

        public string Result()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var soldier in this._soldiers)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
