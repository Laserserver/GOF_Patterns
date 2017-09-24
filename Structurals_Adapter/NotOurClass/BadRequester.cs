using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurals_Adapter
{
    class BadRequester
    {
        public void SendRequest(string message)
        {
            Console.WriteLine("Request " + message);
            //Сас
        }
    }
}
