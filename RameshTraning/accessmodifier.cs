using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameshTraning
{
    class accessmodifier
    {
        public void Name()
        {
            Console.WriteLine("My Name is Ramesh");
        }
    }
    class accessmodifier1
    {
        public void Name1()
        {
            Console.WriteLine("Your Name is Ramesh Maddineni");
        }
    }
    class accessmodifierprivate
    {
        private void Name2()
        {
            Console.WriteLine("Your Name is Ramboo");
        }
    }
    class accessmodifierprotected
    {
        protected int a = 24;
        public void Age()
        {
            Console.WriteLine("My Age is:"+a);
        }

    }
    class accessmodifierprotected1:accessmodifierprotected
    {
        public void Age1()
        {
            Console.WriteLine("My Age is:"+a);
            //We can access a value accessmodifier is protected by using protected we can access base class members and derived class members
        }

    }
    class accessmodifierProtectedinternal
    {

    }





}
