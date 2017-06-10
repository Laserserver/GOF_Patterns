using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory2
{
    class ProductA2 : IProductA
    {
        private Action<string> _textWriter;
        public ProductA2(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Продукт 2 A создан");
        }

        public void OperationA()
        {
            _textWriter("Операция продукта 2 А");
        }
    }
}
