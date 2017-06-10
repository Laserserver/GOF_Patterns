using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationals_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create director and builders
            Director director = new Director();

            IBuilder b1 = new Builder1();
            IBuilder b2 = new Builder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user
            Console.Read();
        }
    }
}
