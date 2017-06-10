using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_FactoryMethod.Classes
{
    class ProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Операция продукта B");
        }
    }
}
