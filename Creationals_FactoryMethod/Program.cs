using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_FactoryMethod
{
    /*
        + 1. Позволяет сделать код создания объектов более универсальным, не привязываясь к конкретным классам (ConcreteProduct), а оперируя лишь общим интерфейсом (Product).
        + 2. Позволяет установить связь между параллельными иерархиями классов.
         
        - 1. Необходимость создавать наследника Creator для каждого нового типа продукта (ConcreteProduct).
         */
    using FactoryA = Classes.FactoryA.FactoryA;
    using FactoryB = Classes.FactoryB.FactoryB;

    class Program
    {
        static void Main(string[] args)
        {
            IFactory factoryA = new FactoryA();
            IFactory factoryB = new FactoryB();

            IProduct productA = factoryA.CreateProduct();
            IProduct productB = factoryB.CreateProduct();

            productA.Operation();
            productB.Operation();
            
            Console.ReadLine();
        }
    }
}
