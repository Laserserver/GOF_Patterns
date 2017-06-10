using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Singleton
{
    /*
        + 1. Контролируемый доступ к единственному экземпляру.

        - 1. Глобальные объекты могут быть вредны для объектного программирования,
             в некоторых случаях приводят к созданию немасштабируемого проекта.
        - 2. Усложняет написание модульных тестов и следование TDD.
         */
    class Program
    {
        static void Main(string[] args)
        {
            Singleton _instance = Singleton.Get();

            _instance.Operation();

            _instance = Singleton.Get();

            _instance.Operation();

            Console.ReadLine();
        }
    }
}
