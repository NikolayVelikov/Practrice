namespace Army_Hierarchy.Core.Entities
{
    using System.Linq;
    using System.Collections.Generic;

    using Army_Hierarchy.Core.Contracts;
    using Army_Hierarchy.Factory.Contracts;
    using Army_Hierarchy.Models.Contracts;

    public class Interpreter : IInterpreter
    {
        private IFactory _factory;

        public Interpreter(IFactory factory)
        {
            this._factory = factory;
        }

        public void Private(string[] input)
        {
            string id = input[0];
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);

            this._factory.Private(id, firstName, lastName, salary);
        }

        public void LieutenantGeneral(string[] input)
        {
            string id = input[0];
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);

            if (input.Length > 4)
            {
                string[] ids = input.Skip(4).ToArray();

                this._factory.LieutenantGeneralWithOfficers(id, firstName, lastName, salary, ids);
            }
            else
            {
                this._factory.LieutenantGeneral(id, firstName, lastName, salary);
            }

        }

        public void Engineer(string[] input)
        {
            string id = input[0];
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);
            string corp = input[4];
            List<IRepair> repairs = new List<IRepair>();

            if (input.Length > 5)
            {
                for (int i = 5; i < input.Length; i+= 2)
                {
                    string partName = input[i];
                    int workedHours = int.Parse(input[i + 1]);

                    IRepair repair = this._factory.Repair(partName, workedHours);
                    repairs.Add(repair);
                }

                this._factory.Engineer(id, firstName, lastName, salary, corp, repairs);
            }
            else
            {
                this._factory.Engineer(id, firstName, lastName, salary, corp, repairs);
            }

        }

        public void Commando(string[] input)
        {
            string id = input[0];
            string firstName = input[1];
            string lastName = input[2];
            decimal salary = decimal.Parse(input[3]);
            string corp = input[4];
            List<IMission> missions = new List<IMission>();

            if (input.Length > 5)
            {
                for (int i = 5; i < input.Length; i += 2)
                {
                    string codeName = input[i];
                    string state = input[i + 1];
                    try
                    {
                        IMission mission = this._factory.Mission(codeName,state);
                        missions.Add(mission);
                    }
                    catch (System.Exception)
                    {
                        continue;
                    }
                }

                this._factory.Commando(id, firstName, lastName, salary, corp, missions);
            }
            else
            {
                this._factory.Commando(id, firstName, lastName, salary, corp, missions);
            }
        }

        public void Spy(string[] input)
        {
            string id = input[0];
            string firstName = input[1];
            string lastName = input[2];
            int codeNumber = int.Parse(input[3]);

            this._factory.Spy(id, firstName, lastName, codeNumber);
        }

        public string Print()
        {
            return this._factory.Result();
        }
    }
}
