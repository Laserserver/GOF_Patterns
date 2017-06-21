using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurals_Adapter
{
    /*
        Адаптер наделяет определенным интерфейсом класс, недоступный для модификации
         
        Можно организовывать через класс и экземпляр 
         */
    class Program
    {
        static void Main(string[] args)
        {
            IRequester first = new Adapter_Class();
            first.Send("Sas first");
            IRequester second = new Adapter_Object();
            second.Send("Sas second");
            Console.Read();
        }
    }
}
