namespace Army_Hierarchy.Models.Entities.Private.LieutenantGeneral
{
    using System.Linq;
    using System.Collections.Generic;

    using Army_Hierarchy.Models.Contracts.Private;
    using Army_Hierarchy.Models.Contracts.Private.LieutenantGeneral;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private IList<IPrivate> _privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this._privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>)this._privates;

        public void Add(IPrivate @private)
        {
            if (_privates.FirstOrDefault(p => p.Id == @private.Id) == null)
            {
                this._privates.Add(@private);
            }
        }
    }
}
