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

        public static void Testing(int age)
        {
            Console.WriteLine("My Age is:" + age);
        }

        //Condition to check large number between two numbers
        public static void CheckLargeNumber()
        {
            Console.WriteLine("Enter First No:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (a > b)
                {
                    Console.WriteLine("a is Greater than b");
                }
                else
                {
                    Console.WriteLine("a is equal to b");
                }
            }
            else
            {
                Console.WriteLine("a is less than b");
                Console.ReadLine();
            }
               
        }


        private static void VowelConsonentChecker()
        {
            Console.WriteLine("Enter Your letter:");
            char c = Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case 'a':
                    Console.WriteLine("it is vowel");
                    break;
                case 'e':
                    Console.WriteLine("it is vowel");
                    break;
                case 'i':
                    Console.WriteLine("it is vowel");
                    break;
                case 'o':
                    Console.WriteLine("it is vowel");
                    break;
                case 'u':
                    Console.WriteLine("it is vowel");
                    break;
                default:
                    Console.WriteLine("It is Consonent");
                    break;
            }
        }



        public static void SwitchconditionEx()
        {
            Console.WriteLine("Enter First No:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No:");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (a>b)
            {
                case true:
                    Console.WriteLine("a greater than b");
                    break;
                case false:
                    if(b>a)
                    Console.WriteLine("b is greater than a");
                    else
                        Console.WriteLine("a and b eqal");
                    break;
            }
        }

    }
}
