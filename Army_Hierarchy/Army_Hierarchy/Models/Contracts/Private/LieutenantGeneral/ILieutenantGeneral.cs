using System.Collections.Generic;

namespace Army_Hierarchy.Models.Contracts.Private.LieutenantGeneral
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void Add(IPrivate @private);
    }
}
