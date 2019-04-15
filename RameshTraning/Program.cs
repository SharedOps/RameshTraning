using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RameshUtilityLibrary.Conditions;

namespace RameshTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condition.Test("Ramesh");
            //Condition.Testing(24);
            //Condition.Ifelsecondition();
            //Condition.switchcondition();
            //Condition.SwitchconditionEx();
            accessmodifier am = new accessmodifier();
            am.Name();
            accessmodifier1 am1 = new accessmodifier1();
            am1.Name1();
            accessmodifierprivate amp = new accessmodifierprivate();
            //class member access modifier is private
        }
    }
}
