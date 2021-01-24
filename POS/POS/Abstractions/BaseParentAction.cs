using POS.Presentation.Extensions;
using System.Collections.Generic;

namespace POS.Presentation.Abstractions
{
    public abstract class BaseParentAction : IAction
    {
        public int MenuIndex { get; set; }
        public string Label { get; set; }
        public IList<IAction> Actions { get; set; }

        protected BaseParentAction(IList<IAction> actions) 
        {
            actions.SetActionIndex();
            Actions = actions;
        }

        public virtual void Call() 
        {
            Actions.PrintActionsAndCall();
        }
    }
}
