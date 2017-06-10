using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static Action<string> _textWriter;

        private Singleton()
        {
            _textWriter = (string text) => Console.WriteLine(text);
            _textWriter("Одиночка создан.");
        }

        public static Singleton Get()
        {
            if (_instance == null)
                _instance = new Singleton();
            _textWriter("Одиночка возвращен.");
            return _instance;
        }

        public void Operation()
        {
            _textWriter("Операция одиночки.");
        }
    }
}
