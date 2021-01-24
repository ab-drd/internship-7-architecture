using System;
using System.Collections.Generic;
using System.Linq;
using POS.Presentation.Abstractions;
using POS.Presentation.Helpers;
using POS.Presentation.Actions;

namespace POS.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void PrintActionsAndCall(this IList<IAction> actions) 
        {
            var isExiting = false;

            do
            {
                foreach (var action_ in actions)
                {
                    Console.WriteLine($"{action_.MenuIndex}. - {action_.Label}");
                }

                var actionIndex = InputHelper.IntInputAndCheck(1, actions.Count);

                var action = actions.FirstOrDefault(a => a.MenuIndex == actionIndex);

                isExiting = action is ExitMenuAction;

                action.Call();
            }
            while (!isExiting);
        }

        public static void SetActionIndex(this IList<IAction> actions)
        {
            for (var i = 0; i < actions.Count; i++) 
            {
                actions[i].MenuIndex = i + 1;
            }
        }
    }
}
