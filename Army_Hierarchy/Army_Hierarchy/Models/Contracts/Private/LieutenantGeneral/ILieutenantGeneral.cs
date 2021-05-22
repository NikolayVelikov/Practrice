namespace Army_Hierarchy.Models.Contracts.Private.LieutenantGeneral
{
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void Add(IPrivate @private);
    }
}
