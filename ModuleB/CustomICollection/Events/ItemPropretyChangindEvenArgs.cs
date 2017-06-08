using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomICollection.Events
{
    public class ItemPropretyChangindEvenArgs<T>:ItemPropretyChangedEvenArgs<T>
    {
        public ItemPropretyChangindEvenArgs(T item) : base(item)
        {
        }

        public bool Cancel { get; set; }
    }
}
