using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Prototype
{
    class Prototype1 : IPrototype
    {
        public int Data { get; set; }

        public Prototype1(int data)
        {
            Data = data;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public IPrototype Clone()
        {
            Console.WriteLine("Клонирование прототипа 1.");
            return (IPrototype)MemberwiseClone();
        }

        public void Operation()
        {
            Console.WriteLine("Операция прототипа 1.");
            Console.WriteLine(Data);
        }
    }
}
