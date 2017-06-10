using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory1
{
    class ProductA1 : IProductA
    {
        private Action<string> _textWriter;
        public ProductA1(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Продукт 1 А создан");
        }

        public void OperationA()
        {
            _textWriter("Операция продукта 1 А");
        }
    }
}
