namespace Army_Hierarchy.Contracts
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}
