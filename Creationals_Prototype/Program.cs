using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrototype pr1 = new Prototype1(10);
            IPrototype pr2 = new Prototype2(20);

            pr1.Operation();
            pr2.Operation();

            pr1.Data += 10;
            pr2.Data *= 20;

            IPrototype cpr1 = pr1.Clone();
            IPrototype cpr2 = pr2.Clone();

            pr1.Operation();
            pr2.Operation();

            Console.ReadLine();
        }
    }
}
