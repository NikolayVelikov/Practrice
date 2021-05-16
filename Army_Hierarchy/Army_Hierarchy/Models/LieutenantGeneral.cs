using Army_Hierarchy.Contracts;
using System.Collections.Generic;

namespace Army_Hierarchy.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private IList<IPrivate> _privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this._privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates => this._privates;

        public void AddPrivate(IPrivate @private)
        {
            this._privates.Add(@private);
        }
    }
}
