using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshUtilityLibrary.Conditions
{
   public static class Condition
    {
        public static void Test(string name)
        {
            if (name != null)
            {
                Console.WriteLine("Name is "+ name);
            }

        }

    }
}
