using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_FactoryMethod.Classes.FactoryB
{
    class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            Console.WriteLine("Вызов фабричного метода фабрики В");
            return new ProductB();
        }
    }
}
