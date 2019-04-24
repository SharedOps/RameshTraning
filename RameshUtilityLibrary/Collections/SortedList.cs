using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshUtilityLibrary.Collections
{
   public static class SortedList
    {
        public static void CreatSortData()
        {
            var Srtlist = new SortedList<string, int>();
            Srtlist.Add("Mani", 30);
            Srtlist.Add("Sravani",23);
            Srtlist.Add("Pradeep", 26);
            Srtlist.Add("Ramesh", 24);
            Srtlist.Add("Chaitra", 2);
            Srtlist.Remove("Ramesh");//remove based on key value
            Srtlist.RemoveAt(2);//remove based on index value
            for(int i=0;i<Srtlist.Count;i++)
            {
                Console.WriteLine(Srtlist.Values[i]);
            }
            foreach (var item in Srtlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
