using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Builder
{
    class Builder1 : IBuilder
    {
        private readonly Product product = new Product();

        public void BuildPartA()
        {
            product.Add("PartX");
        }

        public void BuildPartB()
        {
            product.Add("PartY");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
