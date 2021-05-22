namespace Army_Hierarchy.Models.Entities.Private.SpecialisedSoldier
{
    using System;

    using Army_Hierarchy.Enumerators;
    using Army_Hierarchy.Models.Contracts.Private.SpecialisedSoldier;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corp = Verification(corp);
        }

        public Corps Corp { get; private set; }

        private Corps Verification(string corp)
        {
            Corps currentCorp;
            if (!Enum.TryParse<Corps>(corp, out currentCorp))
            {
                throw new ArgumentOutOfRangeException();
            }

            return currentCorp;
        }
    }
}
