using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory2
{
    class ProductB2 : IProductB
    {
        private Action<string> _textWriter;
        public ProductB2(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Продукт 2 B создан");
        }

        public void OperationB()
        {
            _textWriter("Операция продукта 2 B");
        }
    }
}
