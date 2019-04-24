using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshUtilityLibrary.Collections
{
   public static  class DictionaryExamples
    {
        public static void CreateData()
        {
            var family = new Dictionary<int, string>();
            family.Add(0, "Mani");
            family.Add(1, "Sravani");
            family.Add(2, "Pradeep");
            family.Add(3, "Ramesh");
            string result;
            if(family.TryGetValue(7,out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("key is not found");
            }
           // family.Remove(3);
            Console.WriteLine("ContainsKey 4? {0}", family.ContainsKey(4));
            foreach (var item in family)
            {
                Console.WriteLine(item);
                
            }
            for (int i = 0; i < family.Count; i++)
            {
                Console.WriteLine(family[i]);
            }
            

        }
        
    }
}
