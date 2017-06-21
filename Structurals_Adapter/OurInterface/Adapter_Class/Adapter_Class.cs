using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurals_Adapter
{
    /// <summary>
    /// Хороший вариант
    /// </summary>
    class Adapter_Class : BadRequester, IRequester
    {
        public void Send(string message)
        {
            SendRequest(message);
        }
    }
}
