using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CustomICollection.Events;

namespace CustomICollection
{
    public class MList<T> :ICollection<T>
    {
        private readonly List<T> _list;
        public event EventHandler<ItemPropretyChangedEvenArgs<T>> PropretyChanged;
        public event EventHandler<ItemPropretyChangindEvenArgs<T>> PropretyChanging;
        public event EventHandler<ClearListEvenArgs> ListCleared;
        public EventHandler<ClearListEvenArgs> ListClearing;
         
        public MList(List<T> list)
        {
            _list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
           return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            var arg = new ItemPropretyChangindEvenArgs<T>(item);
            if (arg.Cancel)
            {
                OnPropretyChanging(arg);
                return;
            }
            OnPropretyChanged(new ItemPropretyChangindEvenArgs<T>(item));
             _list.Add(item);
        }

        public void Clear()
        {
            var arg = new ClearListEvenArgs();
            if (arg.Cancel)
            {
                OnClearingList(arg);
                return;
            }
            _list.Clear();
            OnClearList(arg);
        }

        public bool Contains(T item)
        {
            var arg = new ItemPropretyChangindEvenArgs<T>(item);
            if (arg.Cancel)
            {
                OnPropretyChanging(arg);
                return false;
            }
            OnPropretyChanged(new ItemPropretyChangindEvenArgs<T>(item));
            return _list.Contains(item);

        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            var arg = new ItemPropretyChangindEvenArgs<T>(item);
            if (arg.Cancel)
            {
                OnPropretyChanging(arg);
            }
            OnPropretyChanged(new ItemPropretyChangindEvenArgs<T>(item));
            return _list.Remove(item);
        }

        public int Count => _list.Count;
        public bool IsReadOnly => (_list as ICollection<T>).IsReadOnly;


        protected virtual void OnPropretyChanged(ItemPropretyChangedEvenArgs<T> e)
        {
            PropretyChanged?.Invoke(this, e);
        }

        protected virtual void OnPropretyChanging(ItemPropretyChangindEvenArgs<T> e)
        {
            PropretyChanging?.Invoke(this, e);
        }

        protected virtual void OnClearList(ClearListEvenArgs e)
        {
            ListCleared?.Invoke(this, e);
        }

        protected virtual void OnClearingList(ClearListEvenArgs e)
        {
            ListClearing?.Invoke(this, e);
        }
    }
}
