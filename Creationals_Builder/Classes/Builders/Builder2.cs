using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Builder
{
    class Builder2 : IBuilder
    {
        private readonly Product product = new Product();

        public void BuildPartA()
        {
            product.Add("PartA");
        }

        public void BuildPartB()
        {
            product.Add("PartB");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
