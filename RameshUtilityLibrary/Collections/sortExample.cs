using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshUtilityLibrary.Collections
{
   public static class sortExample
    {
        public static void CreateData()
        {
            var stk = new Stack<string>();
            stk.Push("Ramesh");
            stk.Push("Sravani");
            stk.Push("Mani");
            stk.Push("Deepu");
            stk.Push("Chaitra");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
