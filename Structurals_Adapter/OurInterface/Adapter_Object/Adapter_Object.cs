using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurals_Adapter
{
    /// <summary>
    /// Плохой вариант
    /// </summary>
    class Adapter_Object : IRequester
    {
        private BadRequester _kisoClass = new BadRequester();

        public void Send(string message)
        {
            _kisoClass.SendRequest(message);
        }
    }
}
