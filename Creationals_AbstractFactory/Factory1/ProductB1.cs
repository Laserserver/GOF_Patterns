using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory1
{
    class ProductB1 : IProductB
    {
        private Action<string> _textWriter;
        public ProductB1(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Продукт 1 B создан");
        }

        public void OperationB()
        {
            _textWriter("Операция продукта 1 B");
        }
    }
}
