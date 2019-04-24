using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshUtilityLibrary.Collections
{
    public static class ListsExample
    {
        public static void CreateData()
        {
            try
            {
                var data = new List<string>
                {
                    "Ramesh",
                    "Ramesh2",
                    "Ramesh3",
                    "Ramesh4",
                    "Ramesh5"
                };

                Console.WriteLine(data);

                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine("using for loop " + data[i]);
                }

                foreach (var element in data)
                {
                    Console.WriteLine($"using for each loop: {element} and string interpolation ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }

        public static void CreateNumberData()
        {
            var data = new List<int>();

            for (var i = 0; i <= 10; i++)
            {
                data.Add(i);
            }

            foreach (var element in data)
            {
                Console.WriteLine(element);
            }
        }
        


    }
}
