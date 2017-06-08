using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
   public class VectorGenerator<T>:IEnumerable<Vector<T>> where T: struct 
    {
        private readonly int _vectorCount;
        private  Random _rand => new Random(DateTime.Now.Second);
        public VectorGenerator(int vectorCount)
        {
            _vectorCount = vectorCount;
        }
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            var i = 0;
            while (i<_vectorCount)
            {
                dynamic x = _rand.Next(-10, 10);
                dynamic y = _rand.Next(-10, 10);
                yield return new Vector<T>(x,y);
                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
