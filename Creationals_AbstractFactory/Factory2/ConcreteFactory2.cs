using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_AbstractFactory.Factory2
{
    class ConcreteFactory2 : IAbstractFactory
    {
        private Action<string> _textWriter;
        public ConcreteFactory2(Action<string> TextWriter)
        {
            _textWriter = TextWriter;
            TextWriter("Фабрика 2 создана");
        }

        public IProductA CreateA()
        {
            return new ProductA2(_textWriter);
        }

        public IProductB CreateB()
        {
            return new ProductB2(_textWriter);
        }
    }
}
