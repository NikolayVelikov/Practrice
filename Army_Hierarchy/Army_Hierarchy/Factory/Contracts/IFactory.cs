namespace Army_Hierarchy.Factory.Contracts
{

    using System.Collections.Generic;

    using Army_Hierarchy.Models.Contracts;

    public interface IFactory
    {
        void Private(string id, string firstName, string lastName, decimal salary);
        void Spy(string id, string firstName, string lastName, int codeNumber);
        void LieutenantGeneral(string id, string firstName, string lastName, decimal salary);
        void LieutenantGeneralWithOfficers(string id, string firstName, string lastName, decimal salary, string[] ids);
        void Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<IRepair> repairs);
        void Commando(string id, string firstName, string lastName, decimal salary, string corps, List<IMission> missions);
        IRepair Repair(string partName, int workedHours);
        IMission Mission(string codeName, string state);
        string Result();
    }
}
