using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory1
{
    class ConcreteFactory1 : IAbstractFactory
    {
        private Action<string> _textWriter;
        public ConcreteFactory1(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Фабрика 1 создана");
        }

        public IProductA CreateA()
        {
            return new ProductA1(_textWriter);
        }

        public IProductB CreateB()
        {
            return new ProductB1(_textWriter);
        }
    }
}
