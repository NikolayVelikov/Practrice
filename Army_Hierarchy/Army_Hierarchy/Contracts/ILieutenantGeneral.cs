using System.Collections.Generic;

namespace Army_Hierarchy.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        public ICollection<IPrivate> Privates { get;}
        public void AddPrivate(IPrivate @private);
    }
}
