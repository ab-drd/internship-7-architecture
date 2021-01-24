using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Presentation.Helpers
{
    public static class InputHelper
    {
        public static int IntInputAndCheck(int range1, int range2)
        {
            var tempInteger = Console.ReadLine();

            bool someSuccessBoolean = int.TryParse(tempInteger, out int someInteger);

            while (!someSuccessBoolean || someInteger < range1 || someInteger > range2)
            {
                if (!someSuccessBoolean)
                    Console.WriteLine("ERROR: Could not parse -> repeat input");

                else
                    Console.WriteLine("ERROR: Number out of range {0} - {1} -> repeat input",
                        range1, range2);

                tempInteger = Console.ReadLine();
                someSuccessBoolean = int.TryParse(tempInteger, out someInteger);
            }

            return someInteger;
        }
    }
}
