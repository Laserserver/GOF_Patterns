using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Builder
{
    class Director
    {
        public void Construct(IBuilder Builder)
        {
            Builder.BuildPartA();
            Builder.BuildPartB();
        }
    }
}
