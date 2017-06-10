using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Prototype
{
    interface IPrototype : ICloneable
    {
        int Data { get; set; }

        new IPrototype Clone();

        void Operation();
    }
}
