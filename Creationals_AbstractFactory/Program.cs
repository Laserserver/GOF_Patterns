using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory
{
    using FirstFactory = Factory1.ConcreteFactory1;
    using SecondFactory = Factory2.ConcreteFactory2;

    class Program
    {
        /*
         * Абстрактная фабрика, порождающий шаблон
            + 1. Изолирует конкретные классы;
            + 2. Упрощает замену семейств продуктов;
            + 3. Гарантирует сочетаемость продуктов.

            - 1. сложно добавить поддержку нового вида продуктов.
        */
        private static FirstFactory _firstFactory;
        private static SecondFactory _secondFactory;

        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        private static void Test()
        {
            _firstFactory = new FirstFactory((string Text) => Console.WriteLine(Text));
            _secondFactory = new SecondFactory((string Text) => Console.WriteLine(Text));

            IProductA firstProductA = _firstFactory.CreateA();
            IProductA secondProductA = _secondFactory.CreateA();

            IProductB firstProductB = _firstFactory.CreateB();
            IProductB secondProductB = _secondFactory.CreateB();

            firstProductA.OperationA();
            firstProductB.OperationB();
            secondProductA.OperationA();
            secondProductB.OperationB();
        }
        
    }
}
