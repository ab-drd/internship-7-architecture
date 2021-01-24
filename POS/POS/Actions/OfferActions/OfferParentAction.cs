using System;
using System.Collections.Generic;
using POS.Presentation.Abstractions;

namespace POS.Presentation.Actions.OfferActions
{
    public class OfferParentAction : BaseParentAction
    {
        public OfferParentAction(IList<IAction> actions) : base(actions) 
        {
            Label = "Manage offers";
        }

        public override void Call()
        {
            Console.WriteLine("Offer management");
            base.Call();
        }
    }
}
