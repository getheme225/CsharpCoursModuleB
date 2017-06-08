using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomICollection.Events
{
   public class ClearListEvenArgs: EventArgs
    {
        public bool Cancel { get; set; }
    }
}
