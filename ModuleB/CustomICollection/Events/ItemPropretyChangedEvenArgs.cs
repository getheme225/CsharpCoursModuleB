using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomICollection.Events
{
    public class ItemPropretyChangedEvenArgs<T>:EventArgs
    {
        public ItemPropretyChangedEvenArgs(T item)
        {
            Item = item;
        }

        public  T Item { get; private set ; }

    }
}
