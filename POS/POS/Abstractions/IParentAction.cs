using System.Collections.Generic;

namespace POS.Presentation.Abstractions
{
    public interface IParentAction : IAction
    {
        IList<IAction> Actions { get; set; }
    }
}
